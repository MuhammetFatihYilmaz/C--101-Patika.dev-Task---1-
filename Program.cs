using System;

namespace algoritma_sorulari_Patika.dev
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstCase();
            SecondCase();
            ThirdCase();
            FourthCase();



        static void FirstCase()
        {
            int number;
            int arrayNumber;
            bool isNumber;
            bool isArrayNumber;

            Console.Write("Dizinin boyutu için pozitif bir tam sayı giriniz: ");
            isNumber = int.TryParse(Console.ReadLine(), out number);

            while(!isNumber)
            {
            Console.Write("Hatalı giriş yaptınız. Dizinin boyutu için pozitif bir tam sayı giriniz: ");
            isNumber = int.TryParse(Console.ReadLine(), out number);
            }


            int[] array = new int[number];
            

            for(int i =0; i<number;i++)//hata
            {
                Console.WriteLine("Pozitif bir tam sayı giriniz: ");
                isArrayNumber = int.TryParse(Console.ReadLine(), out arrayNumber);
                while(!isArrayNumber)
                {
                Console.WriteLine("Hatalı giriş yaptınız. Pozitif bir tam sayı giriniz: ");
                isArrayNumber = int.TryParse(Console.ReadLine(), out arrayNumber);               
                }
                array[i] = arrayNumber;
            }

            Console.WriteLine("Çift sayılar : ");

            for(int i =0; i<array.Length;i++)
            {

                if(array[i]%2==0)
                {
                    Console.WriteLine(array[i]);
                }
            }
            

        }

        static void SecondCase()
        {
            int numberN;
            int arrayNumberN;
            int numberM;
            bool isNumberN;
            bool isArrayNumberN;
            bool isNumberM;

            Console.Write("Dizinin boyutu için pozitif bir tam sayı giriniz: ");
            isNumberN = int.TryParse(Console.ReadLine(), out numberN);

            while(!isNumberN)
            {
            Console.Write("Hatalı giriş yaptınız. Dizinin boyutu için pozitif bir tam sayı giriniz: ");
            isNumberN = int.TryParse(Console.ReadLine(), out numberN);
            }

            int[] array = new int[numberN];


            for(int i =0; i<numberN;i++)
            {
                Console.Write("Pozitif bir tam sayı giriniz: ");
                isArrayNumberN = int.TryParse(Console.ReadLine(), out arrayNumberN);
                while(!isArrayNumberN)
                {
                Console.WriteLine("Hatalı giriş yaptınız. Pozitif bir tam sayı giriniz: ");
                isArrayNumberN = int.TryParse(Console.ReadLine(), out arrayNumberN);               
                }

                array[i] = arrayNumberN;
             }

            Console.Write("İkinci pozitif bir tam sayı giriniz: ");
            isNumberM = int.TryParse(Console.ReadLine(), out numberM);

            while(!isNumberM)
            {
            Console.Write("Hatalı giriş yaptınız. İkinci pozitif bir tam sayı giriniz: ");
            isNumberM = int.TryParse(Console.ReadLine(), out numberM);
            }

            Console.WriteLine("Dizinin içerisindeki sayıların, ikinci girilen sayıya eşit olan ya da tam bölünen sayıları: ");

            for(int i =0; i<array.Length;i++)
            {
                if(array[i]==numberM)
                    Console.WriteLine($"İkinci girilen sayıya eşit olan sayı : {array[i]}");
                
                else if(array [i]%2==0)
                    Console.WriteLine($"İkinci girilen sayıya tam bölünen sayı: {array[i]}");
                
                
                
                
            }

        }

        static void ThirdCase ()
        {
            int numberN;
            int arrayNumberN;
            bool isNumberN;
            bool isArrayNumberN;

            string word ="";

            Console.Write("Dizinin boyutu için pozitif bir tam sayı giriniz: ");
            isNumberN = int.TryParse(Console.ReadLine(), out numberN);

            while(!isNumberN)
            {
            Console.Write("Hatalı giriş yaptınız. Dizinin boyutu için pozitif bir tam sayı giriniz: ");
            isNumberN = int.TryParse(Console.ReadLine(), out numberN);
            }

            
            string[] wordArray = new string[numberN];


            for(int i =0; i<numberN;i++)
            {
                Console.Write("Bir kelime giriniz: ");
                word = Console.ReadLine();
                isArrayNumberN = int.TryParse(word, out arrayNumberN);

                    
                while(isArrayNumberN)
                {
                Console.WriteLine("Hatalı giriş yaptınız. Bir kelime giriniz: ");
                word = Console.ReadLine();
                isArrayNumberN = int.TryParse(word, out arrayNumberN);  
                }
                wordArray[i] = word;                
             }

             Array.Reverse(wordArray);
             foreach (string words in wordArray)
             {
                Console.WriteLine(words);
             }


        }

        static void FourthCase()
        {
            string trySentence = "";
            string sentence = "";
            string[] sentenceArray;
            char[] sentenceCharArray;
            int number;
            bool isInteger;

                Console.Write("Bir cümle yazınız: ");
                trySentence = Console.ReadLine();
                isInteger = int.TryParse(trySentence, out number);

                    
                while(isInteger)
                {
                Console.Write("Hatalı giriş yaptınız. Bir cüme yazınız: ");
                trySentence = Console.ReadLine();
                isInteger = int.TryParse(trySentence, out number);  
                }
                
                sentence =   trySentence;

                sentence = sentence.Replace(".",string.Empty);
                sentence = sentence.Replace(",",string.Empty);

                sentenceArray = sentence.Split(" ");
                Console.WriteLine($"Toplam kelime sayısı : {sentenceArray.Length}");



                sentence = sentence.Replace(" ",string.Empty);
                sentenceCharArray = sentence.ToCharArray();
                Console.WriteLine($"Toplam harf sayısı : {sentenceCharArray.Length}");

        }



        }
    }
}
