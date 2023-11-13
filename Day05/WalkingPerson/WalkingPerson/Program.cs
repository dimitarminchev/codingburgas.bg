namespace WalkingPerson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            for (int i = 0; i < 200; i++)
            {
                int value = rnd.Next();
                while (value >= 16)
                {
                    value %= 16;
                }
                switch (value)
                {
                    case 0:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 1:
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case 2:
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case 3:
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case 4:
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case 5:
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case 6:
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;
                    case 7:
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    case 8:
                        Console.BackgroundColor = ConsoleColor.DarkMagenta;
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;
                    case 9:
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case 10:
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        break;
                    case 11:
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        break;
                    case 12:
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;
                    case 13:
                        Console.BackgroundColor = ConsoleColor.Magenta;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case 14:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case 15:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;
                        break;
                    case 16:
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                }
                Console.WriteLine("                                       ..,,,..");
                Console.WriteLine("                              *(/(/(//////////******,.");
                Console.WriteLine("                         /(((((((((/////////*************.");
                Console.WriteLine("                     ,###((((((/(/(////////*//*******,*****,,");
                Console.WriteLine("                  ,#####(((((((((/////////**************,****,,.");
                Console.WriteLine("                ########((((((////(//*/*/***********,,,,*,,*,,,,,,");
                Console.WriteLine("              #%%#####(((((((((///////***/***,,*,,,,,,,,,,,,,,*,,,,,");
                Console.WriteLine("            %%%%%#####((((((((/////*//******,*,,,,,,,,,,,,,,,,,,,,,,,.");
                Console.WriteLine("          %%%%%%##%###(#((((((////////********,,,,,,,,,,,,,,,,,,,,,,,,,");
                Console.WriteLine("        ,%%%%%#%######((((((((////*///******,,*,,,,.,,.,,.,,,,,,,,,,,,,,.");
                Console.WriteLine("       #%%%%%%%########(((((((/////*/*****,*,*,,*,,.,,.,,,,.,,,,,,,,,,,,,,");
                Console.WriteLine("      #%%%%%%%#%#####(#(#(((((/////(**********,,,,,,..,.,,,,,,,,,,,,,,*,,,,");
                Console.WriteLine("     #%%%%%%########(##(((((((/////*//*******,,,,,.,..,.,,.,,,,,,,,,,,**,,,,");
                Console.WriteLine("    #%%%%%%%#%#######(#(((((((/(///////******,,,,,,,,..,.,..,,,,,,,,,,***,,,,");
                Console.WriteLine("   (%%%%%%%%%%%######(((((((((///(/(///******,,*,,,,,,,..,,,,,,,,,,,,,,,,,,,,,");
                Console.WriteLine("  (%%%%%%%%%%#########(#((((////(/////*///****,,*,,,,,,,,.,,,.,,*,,,,,,,,,,,,,.");
                Console.WriteLine(" .#%%%%%%%%%%########((#((((((/(/////(///**//***,,,,,,,,,,,,,,,,,*,,,,,,,,**,,,");
                Console.WriteLine(" (#%%%%%%%%%%%%######(((((((((((/(//////*/*******,,,,,,,,,,,,,,,,,,**,*,,,,,,,,,");
                Console.WriteLine(" #%%%%%%%%%%%%%######(((#((((((/////(//*//*/*******,,,,,,,,,,,,,,,,,*,,*,,,*,*,,");
                Console.WriteLine("*#%%%%%%%%%%%%#####((##(((((((/(//////////*/****,****,,*,,,,,,*,,,,,*,,,**,*,*,,");
                Console.WriteLine("(#%%%%%%%%%%%%#######((((((((((/(/////////*/*/******,,,,,,*,,,,,,,,,,**,*,,,,,*,.");
                Console.WriteLine("(#%%%%%%%%%%%########(#(((((((/(((///////*/**********,*,,,,,,,,**,,,,,*,,*,,***,,");
                Console.WriteLine("(#%%%%%%%%%#%#######(#(((((((((/(///////////*/*******,*,*,,,,,,**,,,,,*,,**,,*,,.");
                Console.WriteLine("(####%%#%%%#%#########((#(((((((((///(////////*/******,***,,,,,*,,,,,*****,,**,,");
                Console.WriteLine("*(#####%%%#########((((#(((((#((/((/(/////(//***/*********,,*,*,,,*,**,,***,*,,*");
                Console.WriteLine(" (######%##########(((#(((((((/(((///(///*//*//************,*,*********,***,*,*,");
                Console.WriteLine(" /(###################(#(((((((((((/(////*//**//****************,**,***,*,***,,");
                Console.WriteLine("  (#################((((((((((((///(/////////***/**/*******,*****************,,");
                Console.WriteLine("  .##################((#(((((((((((///(/////////***********************,*****,");
                Console.WriteLine("   *#################(##((((((((((/(/(////////*//****************************");
                Console.WriteLine("   *#################(##((((((((((/(/(////////*//****************************");
                Console.WriteLine("     ,##############((#((#(#((((((((/((/(/(/(//*/////*/********************");
                Console.WriteLine("       #############(###(((((((((#/(/(((/////////(/*//*///****************");
                Console.WriteLine("        *###########((#(##(#(((((((/((/(////(///////*////***************,");
                Console.WriteLine("          ###############(#(((#((((#((((/((///////////*////*//*********");
                Console.WriteLine("           #%##########(((((#((((((#(((((///(/////////////////***/**");
                Console.WriteLine("              *############((##(((((((((((((/(//////////////**/****");
                Console.WriteLine("                 (#########(###((((((#(((((((////////////////***,");
                Console.WriteLine("                    ,##########(###(((((((((((//(/(/////////*.");
                Console.WriteLine("                        .%########(##(((((((((((((///////,");
                Console.WriteLine("                              .(#########((((((((((*");
                Thread.Sleep(30);
                Console.Clear();
            }
        }
    }
}