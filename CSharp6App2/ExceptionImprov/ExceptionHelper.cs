using System.Net;
using System;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CSharp6App2.AutoProperty;

namespace CSharp6App2.ExceptionImprov
{
    public class ExceptionHelper
    {
        #region ex1
        [System.Diagnostics.CodeAnalysis.SuppressMessage("SonarQube", "S2228:Console logging should not be used", Justification = "<Pending>")]
        public void ReadDataFromGoogle()
        {
            try
            {
                var site = "http://www.google.coom/";
                var req = WebRequest.Create(site);
                var res = req.GetResponse();
                //Console.WriteLine($"Content length: {res.ContentLength}");
            }
            catch (WebException ex) when (ex.Status == WebExceptionStatus.NameResolutionFailure)
            {

                Console.WriteLine("Handle NameResolutionFailure");
            }
            catch (WebException ex) when (ex.Status == WebExceptionStatus.ConnectFailure)
            {
                Console.WriteLine("Handle ConnectFailure");
            }
            catch (CustomException ex) when (ex.Severity > 50)
            {
                SqlExceptionManager.HandleException(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Handle generic ex");
            }
        }
        #endregion

        #region ex2
        [System.Diagnostics.CodeAnalysis.SuppressMessage("SonarQube", "S2228:Console logging should not be used", Justification = "<Pending>")]
        public async void ReadDataFromGoogle2()
        {
            try
            {
                var site = "http://www.google.coom/";
                var req = WebRequest.Create(site);
                var res = req.GetResponse();
            }
            catch (WebException ex) when (ex.Status == WebExceptionStatus.NameResolutionFailure)
            {
                var t = Task.Factory.StartNew(DoSomethingThatTakesTime1(ex.Status));

                await t;
            }
            catch (WebException ex) when (ex.Status == WebExceptionStatus.ConnectFailure)
            {
                await LogExceptionAsync(ex);
            }
            finally
            {
                Console.WriteLine("Finally - waite 1sec");
                await Task.Delay(2000);
            }
        }

        #region ex3

        public void ShowCompanyDetails()
        {
            try
            {
                Company companyObject = null; // get db company

                Console.WriteLine(companyObject.FullName);
            }
            catch (Exception ex) when (ex is NullReferenceException)
            {
                Console.WriteLine($"{nameof(Company)} class is null! ");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        private Task LogExceptionAsync(WebException ex)
        {
            throw new NotImplementedException();
        }

        private Action DoSomethingThatTakesTime2(WebExceptionStatus status)
        {
            throw new NotImplementedException();
        }

        private Action DoSomethingThatTakesTime1(WebExceptionStatus status)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Public Methods
        [System.Diagnostics.CodeAnalysis.SuppressMessage("SonarQube", "S2325:Methods and properties that don't access instance data should be static", Justification = "<Pending>")]
        public void NameResolutionFailureMethod()
        {
            Console.WriteLine("Handle NameResolutionFailure");
        }
        #endregion
    }

    internal class CustomException: Exception
    {
        public int Severity { get; set; }
    }

    internal class SqlExceptionManager
    {
        internal static void HandleException(CustomException ex)
        {
            throw new NotImplementedException();
        }
    }
}
