using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }
        void myShowToolTip(TextBox tB, byte[] arr)
        {
            string hexValues = BitConverter.ToString(arr);
            toolTip_HEX.SetToolTip(tB, StringToBinary(hexValues));
        }

        byte[] myXOR(byte[] arr_text, byte[] arr_key)
        {
            int len_text = arr_text.Length;
            int len_key = arr_key.Length;
            byte[] arr_cipher = new byte[len_text];
            for (int i = 0; i < len_text; i++)
            {
                byte p = arr_text[i];
                byte k = arr_key[i % len_key]; // mod
                byte c = (byte)(p ^ k); // XOR

                arr_cipher[i] = c;
            }
            return arr_cipher;
        }

        string myCipher(TextBox tb_text, TextBox tb_Key, TextBox tb_cipher, string cipher = "")
        {
            string text = tb_text.Text;
            byte[] arr_text;
            if (cipher == "") arr_text = Encoding.UTF32.GetBytes(text);
            else arr_text = Encoding.UTF32.GetBytes(cipher);
            myShowToolTip(tb_text, arr_text); // Create tooltip

            string key = tb_Key.Text;
            byte[] arr_key = Encoding.UTF32.GetBytes(key);
            myShowToolTip(tb_Key, arr_key); // Create tooltip

            byte[] arr_cipher = myXOR(arr_text, arr_key);

            cipher = Encoding.UTF32.GetString(arr_cipher);
            tb_cipher.Text = cipher;
            myShowToolTip(tb_cipher, arr_cipher); // Create tooltip

            return cipher;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_P_IN.Text = "";
            textBox_Key_IN.Text = "";
            textBox_C_IN.Text = "";

            textBox_P_OUT.Text = "";
            textBox_Key_OUT.Text = "";
            textBox_C_OUT.Text = "";

        }

        private void button_XOR_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Key_IN.Text))
            {
                textBox_C_IN.Text = textBox_P_IN.Text;
                //MessageBox.Show("Ви забули ввести ключ?");
                //textBox_Key_IN.Focus();
            }
            else
            {
                string cipher = myCipher(textBox_P_IN, textBox_Key_IN, textBox_C_IN); // зашифрування
                textBox_P_OUT.Text = textBox_C_IN.Text;
                textBox_Key_OUT.Text = textBox_Key_IN.Text;
                myCipher(textBox_P_OUT, textBox_Key_OUT, textBox_C_OUT, cipher); // розшифрування
            }
        }

        private void toolTip_HEX_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
