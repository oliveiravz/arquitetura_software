using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace BSIStore.Controllers {

    public class HelloWorldController : Controller {
        
        // /HelloWorld
        public string Index() {

            return "Hello, World!!";
            
        }

        // /HelloWorld/Welcome
        /*public string Welcome() {

            return "Welcome Page";

        }*/

        public string Welcome(string nome, int ID = 1) {

            return HtmlEncoder.Default.Encode($"Nome: {nome}, ID: {ID}");

        }
    }
}
