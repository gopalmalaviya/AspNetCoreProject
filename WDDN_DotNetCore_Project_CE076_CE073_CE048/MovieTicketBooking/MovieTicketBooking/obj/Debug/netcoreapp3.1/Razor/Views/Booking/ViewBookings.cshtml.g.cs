#pragma checksum "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Booking\ViewBookings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1107d3059722868f15192c579224fb6ed610810a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_ViewBookings), @"mvc.1.0.view", @"/Views/Booking/ViewBookings.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\_ViewImports.cshtml"
using MovieTicketBooking.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\_ViewImports.cshtml"
using MovieTicketBooking.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1107d3059722868f15192c579224fb6ed610810a", @"/Views/Booking/ViewBookings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74d0764ec683f957555843768c7ee9df69f87af1", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_ViewBookings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Booking>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Booking\ViewBookings.cshtml"
  
    ViewBag.Title = "Booking History";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 11 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Booking\ViewBookings.cshtml"
         foreach (var booking in Model)
        {
            var isActive = DateTime.Compare(DateTime.Parse(booking.ShowDate), DateTime.Now) >= 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-4 card text-center my-3\">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 393, "\"", 452, 2);
            WriteAttributeValue("", 401, "card-header", 401, 11, true);
#nullable restore
#line 15 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Booking\ViewBookings.cshtml"
WriteAttributeValue(" ", 412, isActive ? "bg-dark text-white" : "", 413, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 16 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Booking\ViewBookings.cshtml"
               Write(_movieRepo.GetMovie(booking.Show.MovieId).Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <span>(");
#nullable restore
#line 17 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Booking\ViewBookings.cshtml"
                      Write(booking.Show.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span>\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <p class=\"card-title mb-1\"><span class=\"text-muted\">Seat No : </span>");
#nullable restore
#line 20 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Booking\ViewBookings.cshtml"
                                                                                    Write(booking.SeatNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"card-text mb-1\"><span class=\"text-muted\">Time : </span>");
#nullable restore
#line 21 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Booking\ViewBookings.cshtml"
                                                                                Write(booking.Show.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"card-text mb-1\"><span class=\"text-muted\">Price : </span>");
#nullable restore
#line 22 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Booking\ViewBookings.cshtml"
                                                                                 Write(booking.Show.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 1024, "\"", 1083, 2);
            WriteAttributeValue("", 1032, "card-footer", 1032, 11, true);
#nullable restore
#line 24 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Booking\ViewBookings.cshtml"
WriteAttributeValue(" ", 1043, isActive ? "bg-dark text-white" : "", 1044, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 25 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Booking\ViewBookings.cshtml"
               Write(DateTime.Parse(booking.ShowDate).ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 28 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Booking\ViewBookings.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IMovieRepository _movieRepo { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Booking>> Html { get; private set; }
    }
}
#pragma warning restore 1591