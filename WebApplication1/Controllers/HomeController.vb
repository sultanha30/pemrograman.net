Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
    Function Products() As ActionResult
        ViewData("Message") = "PRODUCTS DATA"

        Return View()
    End Function
    Function Merchants() As ActionResult
        ViewData("Message") = "MERCHANTS DATA"

        Return View()
    End Function
End Class
