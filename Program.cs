using System;

namespace forx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lutfen tek yada iki basamaklı pozitif, ilki diğerinden düşük oalcak şekilde 2 farklı sayi giriniz:");
            Int32 x = Int32.Parse(Console.ReadLine()); //diyelim ki 5
            Int32 y = Int32.Parse(Console.ReadLine()); //diyelim ki 10

            if(x<0||x/100>=1){System.Console.WriteLine("Lütfen 3 ve daha fazla basamakli sayilar girmeyiniz. 2 basamagi asmasin.");}
            else if(y<0||y/100>=1){System.Console.WriteLine("Lütfen 3 ve daha fazla basamakli sayilar girmeyiniz. 2 basamagi asmasin.");}
            else if(x>=y){System.Console.WriteLine("ilki ikincisinden düşük olmali");}
            else{
            int a;
            for( a=x; a<=y; a++)
            {

                
              if(a<12) {
                    if(a==2){ System.Console.WriteLine("2");}
                    
                    if(a==3){System.Console.WriteLine("3");}
                    
                    if(a==5){System.Console.WriteLine("5");}
                    
                    if(a==7){System.Console.WriteLine("7");}
                    
                    if(a==11){System.Console.WriteLine("11");}

                    else{continue;};
                    }
                
                else
                {

                if(a%2==0){continue;}
                if(a%3==0){continue;}
                if(a%5==0){continue;}
                if(a%7==0){continue;}
                if(a%11==0){continue;}}
                
                Console.WriteLine(a);}
            }
        }
    }
}