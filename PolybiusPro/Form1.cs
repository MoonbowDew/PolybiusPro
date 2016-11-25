using System;
using System.Windows.Forms;

namespace PolybiusPro
{
    public partial class Form1 : Form
    {
        static char[] Letters = new char[]
        {
            'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л',
            'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш',
            'щ', 'ь', 'ы', 'ъ', 'э', 'ю', 'я', 'А', 'Б', 'В', 'Г', 'Д', 'Е',
            'Ё', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
            'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ', 'Э', 'Ю',
            'Я', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
            'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y',
            'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L',
            'M', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '+', '-', '*',
            '/', '^', '%', '=', '#','\\', '.', ',', ' ', '_', '?', '!', '@',
            ':', '<', '>', '|', ';', '(', ')', '&', '№', '$', '"', '~', '`',
            '\r','\n','{', '}', '[', ']', '♂', 'ї', 'Ї', 'є', 'Є', 'ґ', 'Ґ'
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            if (EncryptedBox.Text == String.Empty)
                EncryptedBox.Text = "first, type your message";
            else
            {
                DecryptedBox.Text = String.Empty;
                DecryptedBox.Text = EncryptData(EncryptedBox.Text);
            }

        }

        static string EncryptData(string TypedMessage)
        {
            int[,] columnsAndRowsArg = CalculateColumnsAndRows(TypedMessage);
            char[] outstr = new char[TypedMessage.Length];
            int[] indexes = new int[TypedMessage.Length];
            int[,] localIntsRight = new int[TypedMessage.Length, 2];
            int[] asistant = new int[TypedMessage.Length * 2];
            for (int i = 0; i < TypedMessage.Length; i++)
            {
                asistant[i] = columnsAndRowsArg[i, 0];
            }

            for (int i = 0; i < TypedMessage.Length; i++)
            {
                asistant[i + TypedMessage.Length] = columnsAndRowsArg[i, 1];
            }

            int k = 1;
            for (int i = 0; i < TypedMessage.Length; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    localIntsRight[i, j] = asistant[k - 1]; //Упорядочить
                    k++;
                }

            }


            for (int i = 0; i < TypedMessage.Length; i++)
            {
                indexes[i] = localIntsRight[i, 0] * 13 - (13 - localIntsRight[i, 1]);
                outstr[i] = Convert.ToChar(Letters[(indexes[i] - 1)]);
            }
            string tmpString = new string(outstr);

            return tmpString;
        }

        static private int[,] CalculateColumnsAndRows(string TypedMessage)
        {
            char[] localTypedMessage = new char[TypedMessage.Length];
            for (int j = 0; j < TypedMessage.Length; j++)
            {
                localTypedMessage[j] = TypedMessage[j];
            }

            int[,] arrayOfColumnsAndRows = new int[TypedMessage.Length, 2];
            int k;
            for (int j = 0; j < TypedMessage.Length; j++) //Column section
            {
                k = 1;
                while (localTypedMessage[j] != Letters[k - 1])
                {
                    k++;
                }

                switch (k % 13)                        //Column section
                {
                    case 0:
                        arrayOfColumnsAndRows[j, 1] = 13;
                        break;
                    case 1:
                        arrayOfColumnsAndRows[j, 1] = 1;
                        break;
                    case 2:
                        arrayOfColumnsAndRows[j, 1] = 2;
                        break;
                    case 3:
                        arrayOfColumnsAndRows[j, 1] = 3;
                        break;
                    case 4:
                        arrayOfColumnsAndRows[j, 1] = 4;
                        break;
                    case 5:
                        arrayOfColumnsAndRows[j, 1] = 5;
                        break;
                    case 6:
                        arrayOfColumnsAndRows[j, 1] = 6;
                        break;
                    case 7:
                        arrayOfColumnsAndRows[j, 1] = 7;
                        break;
                    case 8:
                        arrayOfColumnsAndRows[j, 1] = 8;
                        break;
                    case 9:
                        arrayOfColumnsAndRows[j, 1] = 9;
                        break;
                    case 10:
                        arrayOfColumnsAndRows[j, 1] = 10;
                        break;
                    case 11:
                        arrayOfColumnsAndRows[j, 1] = 11;
                        break;
                    case 12:
                        arrayOfColumnsAndRows[j, 1] = 12;
                        break;
                }

                if (k >= 1 && 13 >= k)           //Row section
                    arrayOfColumnsAndRows[j, 0] = 1;
                else if (k >= 14 && 26 >= k)
                    arrayOfColumnsAndRows[j, 0] = 2;
                else if (k >= 27 && 39 >= k)
                    arrayOfColumnsAndRows[j, 0] = 3;
                else if (k >= 40 && 52 >= k)
                    arrayOfColumnsAndRows[j, 0] = 4;
                else if (k >= 53 && 65 >= k)
                    arrayOfColumnsAndRows[j, 0] = 5;
                else if (k >= 66 && 78 >= k)
                    arrayOfColumnsAndRows[j, 0] = 6;
                else if (k >= 79 && 91 >= k)
                    arrayOfColumnsAndRows[j, 0] = 7;
                else if (k >= 92 && 104 >= k)
                    arrayOfColumnsAndRows[j, 0] = 8;
                else if (k >= 105 && 117 >= k)
                    arrayOfColumnsAndRows[j, 0] = 9;
                else if (k >= 118 && 130 >= k)
                    arrayOfColumnsAndRows[j, 0] = 10;
                else if (k >= 131 && 143 >= k)
                    arrayOfColumnsAndRows[j, 0] = 11;
                else if (k >= 144 && 156 >= k)
                    arrayOfColumnsAndRows[j, 0] = 12;
                else
                    arrayOfColumnsAndRows[j, 0] = 13;

            }
            return arrayOfColumnsAndRows;
        }

        private void BoxCleaner_Click(object sender, EventArgs e)
        {
            DecryptedBox.Text = String.Empty;
            EncryptedBox.Text = String.Empty;
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            if (DecryptedBox.Text == String.Empty)
                DecryptedBox.Text = "first, type your message";
            else
            {
                EncryptedBox.Text = String.Empty;
                EncryptedBox.Text = DecryptData(DecryptedBox.Text);
            }

        }

        static string DecryptData(string TypedMessage)
        {
            int[,] DecrColumnsAndRowsArg = CalculateColumnsAndRows(TypedMessage);
            char[] outstr = new char[TypedMessage.Length];
            int[] indexes = new int[TypedMessage.Length];
            int[,] localInts = new int[TypedMessage.Length, 2];

            int[,] localIntsRight = new int[TypedMessage.Length, 2];
            int[] asistant = new int[TypedMessage.Length * 2];
            int u = 0;

            for (int i = 0; i < TypedMessage.Length; i++)
            {
                for (int z = 0; z < 2; z++)
                {
                    asistant[u++] = DecrColumnsAndRowsArg[i, z];
                }
            }


            int k = 1;
            for (int i = 0; i < TypedMessage.Length; i++)
            {
                localIntsRight[i, 0] = asistant[i]; //order the symbols
                localIntsRight[i, 1] = asistant[i + TypedMessage.Length];

            }

            for (int i = 0; i < TypedMessage.Length; i++)
            {
                indexes[i] = localIntsRight[i, 0] * 13 - (13 - localIntsRight[i, 1]);
                outstr[i] = Convert.ToChar(Letters[(indexes[i] - 1)]);
            }

            string tmpString = new string(outstr);

            return tmpString;
        }
    }
}
