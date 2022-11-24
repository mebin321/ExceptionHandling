using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandling
{
    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                //Access youtube web service
                //Read the data
                //create a list of video objects

                //Throwing an exception to simulate how it will be handled in the catch block
                throw new Exception("oops some low level youtube error. ");

            }
            catch (Exception ex)
            {
                //the second argument is the actual exception being passed wrapped inside the youtube exception
                throw new YouTubeException("Could not fetch the videos from youtube. ", ex);
            }

            return new List<Video>();
        }
    }
    partial class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;

            //when we use the using statement internally the compiler will create a file block under the hood  which will call the dispose method of the stream reader
            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("mebin");
              /*  using (streamReader = new StreamReader(@"c:\file.zip"))
                {
                    var content = streamReader.ReadToEnd();
                }*/
              /*  streamReader = new StreamReader(@"c:\file.zip");
                var content = streamReader.ReadToEnd();
                throw new Exception("oops");*/
                //var calculator = new Calculator();
               // calculator.Divide(5, 0);
                
            }
           /* catch (DivideByZeroException ex) //Order of catch clause is Most Specific to most generic 
            {
                Console.WriteLine("You can not divide by zero");
            }
            catch (ArithmeticException ex)
            {

            }*/
            catch (Exception ex)
            {
                // Console.WriteLine("Sorry an unexpected error occured");
                Console.WriteLine(ex.Message);
            }
           /* finally
            {
                if (streamReader != null)
                    streamReader.Dispose();
            }*/

            //First Comment
            //Second Commit
           
        }
    }
}
