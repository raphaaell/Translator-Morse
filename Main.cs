using System;

/* Created by Raphew */

namespace morse{
    class main{
        static void Main(string[] args){
            Console.WriteLine("Hi to \"morse\"");
            Console.WriteLine("Do you want to trad Morse To Text (MTT) or Text To Morse (TTM) ? (MTT/TTM, default TTM)");
            bool MTT = Console.In.ReadLine() == "MTT" ? true : false;
            if(MTT){
                while(true){
                    Console.Write("Morse : ");
                    String s = Console.In.ReadLine();
                    String[] morse = s.Split(' ');
                    String text = "";
                    for (int i = 0; i < morse.Length; i++){
                        text+=MorseToText(morse[i]);
                    }
                    Console.WriteLine("Text : " + text);
                }
            }else{
                while(true){
                    Console.Write("Text : ");
                    String s = Console.In.ReadLine();
                    char[] text = s.ToCharArray();
                    String morse = "";
                    for (int i = 0; i < text.Length; i++){
                        morse+=TextToMorse(text[i]);
                        morse+=" ";
                    }
                    Console.WriteLine("Morse : " + morse);
                }
            }
            
        }
        static char MorseToText(String arg){
            switch(arg){
                case ".-":
                    return 'a';
                case "-...":
                    return 'b';
                case "-.-.":
                    return 'c';
                case "-..":
                    return 'd';
                case ".":
                    return 'e';
                case "..-.":
                    return 'f';
                case "--.":
                    return 'g';
                case "....":
                    return 'h';
                case "..":
                    return 'i';
                case ".---":
                    return 'j';
                case "-.-":
                    return 'k';
                case ".-..":
                    return 'l';
                case "--":
                    return 'm';
                case "-.":
                    return 'n';
                case "---":
                    return 'o';
                case ".--.":
                    return 'p';
                case "--.-":
                    return 'q';
                case ".-.":
                    return 'r';
                case "...":
                    return 's';
                case "-":
                    return 't';
                case "..-":
                    return 'u';
                case "...-":
                    return 'v';
                case ".--":
                    return 'w';
                case "-..-":
                    return 'x';
                case "-.--":
                    return 'y';
                case "--..":
                    return 'z';
                case "-----":
                    return '0';
                case ".----":
                    return '1';
                case "..---":
                    return '2';
                case "...--":
                    return '3';
                case "....-":
                    return '4';
                case ".....":
                    return '5';
                case "-....":
                    return '6';
                case "--...":
                    return '7';
                case "---..":
                    return '8';
                case "----.":
                    return '9';
                default:
                    break;
            }
            return ' ';
        }
        static String TextToMorse(char arg){
            switch(arg){
                case 'a':
                    return ".-";
                case 'b':
                    return "-...";
                case 'c':
                    return "-.-.";
                case 'd':
                    return "-..";
                case 'e':
                    return ".";
                case 'f':
                    return "..-.";
                case 'g':
                    return "--.";
                case 'h':
                    return "....";
                case 'i':
                    return "..";
                case 'j':
                    return ".---";
                case 'k':
                    return "-.-";
                case 'l':
                    return ".-..";
                case 'm':
                    return "--";
                case 'n':
                    return "-.";
                case 'o':
                    return "---";
                case 'p':
                    return ".--.";
                case 'q':
                    return "--.-";
                case 'r':
                    return ".-.";
                case 's':
                    return "...";
                case 't':
                    return "-";
                case 'u':
                    return "..-";
                case 'v':
                    return "...-";
                case 'w':
                    return ".--";
                case 'x':
                    return "-..-";
                case 'y':
                    return "-.--";
                case 'z':
                    return "--..";
                case '0':
                    return "-----";
                case '1':
                    return ".----";
                case '2':
                    return "..---";
                case '3':
                    return "...--";
                case '4':
                    return "....-";
                case '5':
                    return ".....";
                case '6':
                    return "-....";
                case '7':
                    return "--...";
                case '8':
                    return "---..";
                case '9':
                    return "----.";
                default:
                    break;
            }
            return " ";
        }
    }
}
