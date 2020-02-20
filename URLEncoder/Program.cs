using System;
using System.Collections.Generic;

namespace URLEncoder
{
    class Program
    {
        static string urlFormatString = "https://companyserver.com/content/{0}/files/{1}/{1}Report.pdf";

        static void Main(string[] args)
        {
            Console.WriteLine("URL Encoder");

            do
            {
                Console.Write("\nProject name: ");
                string projectName = GetUserInput();
                Console.Write("Activity name: ");
                string activityName = GetUserInput();

                Console.WriteLine(CreateURL(projectName, activityName));

                Console.Write("Would you like to do another? (y/n): ");
            } while (Console.ReadLine().ToLower().Equals("y"));
        }

        static string CreateURL(string projectName, string activityName) {
            // create the URL string and return it
            string newURL = String.Format(urlFormatString, Encode(projectName), Encode(activityName));
            return newURL;
        }

        static string GetUserInput()                             
        {
            string input = "";
	        do
	        {   
                input = Console.ReadLine();
                if (IsValid(input)) 
                {
                    return input;
                }
                else
                {
                    Console.Write("The input contains invalid characters. Enter again: \n");
                }
	        } while (true);
            // get valid input from the user
            // disallow strings with control characters
            // IsValid() below is used to check if input is valid
        }

        static bool IsValid(string input) {
            foreach (char character in input.ToCharArray()) {
	        // check each character to see if it matches any of the not-allowed control characters
                if(character == 0x00 || character == 0x01 || character == 0x02 || character == 0x03 || character == 0x04 || character == 0x05 || character == 0x06 || character == 0x07 || character == 0x08 || character == 0x09 || character == 0x0A || character == 0x0B || character == 0x0C || character == 0x0D || character == 0x0E || character == 0x0F || character == 0x10 || character == 0x11 || character == 0x12 || character == 0x13 || character == 0x14 || character == 0x15 || character == 0x16 || character == 0x17 || character == 0x18 || character == 0x19 || character == 0x1A || character == 0x1B || character == 0x1C || character == 0x1D || character == 0x1E || character == 0x1F || character == 0x7F)
                {
                    return false;
                }
            }
            return true;
            // check if the string is valid and does not
            // contain control characters
            // if valid, return true
            // if not valid, return false
        }

        static string Encode(string value)
        {
            // return an encoded version of the 
            // string provided in value
            string encodedValue = "";
            foreach (char character in value.ToCharArray()) {
                if(character == 0x24)
                {
                    encodedValue = encodedValue + "%24";
                }
                else if(character == 0x26)
                {
                    encodedValue = encodedValue + "%26";
                }
                else if(character == 0x2B)
                {
                    encodedValue = encodedValue + "%2B";
                }
                else if(character == 0x2C)
                {
                    encodedValue = encodedValue + "%2C";
                }
                else if(character == 0x2F)
                {
                    encodedValue = encodedValue + "%2F";
                }
                else if(character == 0x3A)
                {
                    encodedValue = encodedValue + "%3A";
                }
                else if(character == 0x3B)
                {
                    encodedValue = encodedValue + "%3B";
                }
                else if(character == 0x3D)
                {
                    encodedValue = encodedValue + "%3D";
                }
                else if(character == 0x3F)
                {
                    encodedValue = encodedValue + "%3F";
                }
                else if(character == 0x40)
                {
                    encodedValue = encodedValue + "%40";
                }
                else if(character == 0x20)
                {
                    encodedValue = encodedValue + "%20";
                }
                else if(character == 0x22)
                {
                    encodedValue = encodedValue + "%22";
                }
                else if(character == 0x3C)
                {
                    encodedValue = encodedValue + "%3C";
                }
                else if(character == 0x3E)
                {
                    encodedValue = encodedValue + "%3E";
                }
                else if(character == 0x23)
                {
                    encodedValue = encodedValue + "%23";
                }
                else if(character == 0x25)
                {
                    encodedValue = encodedValue + "%25";
                }
                else if(character == 0x7B)
                {
                    encodedValue = encodedValue + "%7B";
                }
                else if(character == 0x7D)
                {
                    encodedValue = encodedValue + "%7D";
                }
                else if(character == 0x7C)
                {
                    encodedValue = encodedValue + "%7C";
                }
                else if(character == 0x5C)
                {
                    encodedValue = encodedValue + "%5C";
                }
                else if(character == 0x5E)
                {
                    encodedValue = encodedValue + "%5E";
                }
                else if(character == 0x7E)
                {
                    encodedValue = encodedValue + "%7E";
                }
                else if(character == 0x5B)
                {
                    encodedValue = encodedValue + "%5B";
                }
                else if(character == 0x5D)
                {
                    encodedValue = encodedValue + "%5D";
                }
                else if(character == 0x60)
                {
                    encodedValue = encodedValue + "%60";
                }
                else
                {
                    encodedValue = encodedValue + character;
                }
                // build the encodedValue string by getting each character
                // in the original string and adding it to encodedValue if the original is ok
                // OR changing it to an encoded value and adding the encoded value to the string
                // if it is one of the values that needs to change
            }
            return encodedValue;
        }
    }
}