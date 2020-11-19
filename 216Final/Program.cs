using System;

namespace _216Final
{
    class CaesarCipher
    {
        //คำนวน Encryption
        public static char cipherE(char chE, int key)
        {
            if (!char.IsLetter(chE))
            {
                return chE;
            }
            char d = char.IsUpper(chE) ? 'A' : 'a';
            return (char)((((chE + key) - d) % 26) + d);
        }
        //คำนวน  Decrytion
        public static char cipherD(char chD, int key)
        {
            if (!char.IsLetter(chD))
            {
                return chD;
            }
            char d = char.IsUpper(chD) ? 'A' : 'a';
            return (char)((((chD - key) - d) % 26) + d);
        }
        //encipher
        public static string Encipher(string input, int key)
        {
            string output = string.Empty;

            foreach (char chE in input)
                output += cipherE(chE, key);
            return output;
        }
        //Decipher
        public static string Decipher(string input, int key)
        {
            string output = string.Empty;
            foreach (char chD in input)
                output += cipherD(chD, key);
            return output;
        }

        static void Main(string[] args)
        {
            int Text;
            do
            {
                Console.Write("Type 1 to Encrypt : Type 2 to Decype");
                Console.Write("\n");
                Console.Write("Type : ");
                Text = int.Parse(Console.ReadLine());

                if (Text == 1)
                {
                    Console.Write("Type a string to encrypt : ");
                    string UserString = Console.ReadLine();
                    Console.Write("Enter your Key : ");
                    int key = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Encryption Data : ");
                    string cipherText = Encipher(UserString, key);
                    Console.Write(cipherText);
                    Console.Write("\n");

                }
                else if (Text == 2)
                {
                    Console.Write("Type a string to decrypt : ");
                    string UserString = Console.ReadLine();
                    Console.Write("Enter your Key : ");
                    int key = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Decrytion Data : ");
                    string t = Decipher(UserString, key);
                    Console.Write(t);
                    Console.Write("\n");
                }
                else break;
                Console.Write("\n");
            } while (Text != 1 || Text != 2);
            Console.Write("\n");
            Console.ReadLine();
        }
    }
}
