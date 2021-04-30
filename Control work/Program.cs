using System;

namespace Control_work_
{
    class Program
    {
        static void Main(string[] args)
        { 
            string one = " ";
            string two = " ";
            string three = " ";
            string four = " ";
            string five = " ";
            string max = " ";
            int simvInMax = 0;
            string min = " ";
            int simvInMin = 0;
            string [] myArray=new string[] { "Второе предубеждение, стоящее за установкой, что в любви нечему учиться, – это допущение, что проблема любви есть проблема объекта, а не проблема способности.",
"Принято думать, что любить просто, а найти достойный объект для любви или для того, чтобы быть любимым, – вот это трудно.",
"Прежде всего сыграло роль резкое изменение отношения к выбору «объекта любви», происшедшее в XX столетии. В викторианскую эпоху, как и во многих культурах, приверженных традициям, любовь не была непосредственным личным переживанием, которое могло привести затем к браку.",
"Напротив, браки заключались по договору – или при посредничестве каких-либо почтенных семейств либо брачного маклера, или без посредников.",
"Они заключались из соображений, социальных по своей природе. Что же касается любви, то предполагалось, что она появится и будет крепнуть после заключения брака. Однако за время жизни нескольких последних поколений в западном мире почти окончательно восторжествовала концепция романтической любви."};

            for (int i = 0; i < myArray.Length; i++)
            {
                if (i == 0)
                {
                    one = myArray[i];
                }
                else if (i == 1)
                {
                    two = myArray[i];
                }
                else if (i == 2)
                {
                    three = myArray[i];
                }
                else if (i == 3)
                {
                    four = myArray[i];
                }
                else if (i==4)
                {
                    five = myArray[i];
                }
            }

            int oneLength = one.Length;
            int twoLength = two.Length;
            int threeLengt = three.Length;
            int fourLength = four.Length;
            int fiveLength = five.Length;


            if (oneLength>twoLength&&oneLength>threeLengt&&oneLength>fourLength&&oneLength>fiveLength)
            {
                max = one;
                simvInMax = oneLength;
            }
            else if(oneLength < twoLength && oneLength < threeLengt && oneLength < fourLength && oneLength < fiveLength)
            {
                min = one;
                simvInMin = oneLength;
            }

            if (twoLength>oneLength&&twoLength>threeLengt&&twoLength>fourLength&&twoLength>fiveLength)
            {
                max = two;
                simvInMax = twoLength;
            }
            else if (twoLength < oneLength && twoLength < threeLengt && twoLength < fourLength && twoLength < fiveLength)
            {
                min = two;
                simvInMin = twoLength;
            }
            if (threeLengt>oneLength&& threeLengt>twoLength&&threeLengt>fourLength&&threeLengt>fiveLength)
            {
                max = three;
                simvInMax = threeLengt;
            }
            else if (threeLengt < oneLength && threeLengt < twoLength && threeLengt < fourLength && threeLengt < fiveLength)
            {
                min = three;
                simvInMin = threeLengt;
            }
            if (fourLength > oneLength && fourLength > twoLength && fourLength>threeLengt && fourLength > fiveLength)
            {
                max = four;
                simvInMax = fourLength;
            }
            else if (fourLength < oneLength && fourLength < twoLength && fourLength < threeLengt && fourLength < fiveLength)
            {
                min = four;
                simvInMin = fourLength;
            }
            if (fiveLength > oneLength && fiveLength > twoLength && fourLength > fiveLength && fiveLength>fourLength)
            {
                max = five;
                simvInMax = fiveLength;
            }
            else if ((fiveLength < oneLength && fiveLength < twoLength && fourLength < fiveLength && fiveLength < fourLength))
            {
                min = five;
                simvInMin = fiveLength;
            }


        
            Console.WriteLine($"Самое длинное предложегние: {max}, Количество символов: {simvInMax}");
            Console.WriteLine($"Самое длинное предложегние: {min}, Количество символов: {simvInMin}");
            Console.ReadLine();
           
        }
    }
}
