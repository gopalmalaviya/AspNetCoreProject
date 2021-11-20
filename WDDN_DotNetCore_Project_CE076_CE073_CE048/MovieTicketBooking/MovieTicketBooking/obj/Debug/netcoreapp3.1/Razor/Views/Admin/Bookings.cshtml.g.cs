#pragma checksum "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Admin\Bookings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdcaecadb80cd5a3c00d664e78b7592b76c75e4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Bookings), @"mvc.1.0.view", @"/Views/Admin/Bookings.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdcaecadb80cd5a3c00d664e78b7592b76c75e4f", @"/Views/Admin/Bookings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74d0764ec683f957555843768c7ee9df69f87af1", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Bookings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Booking>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Admin\Bookings.cshtml"
  
    ViewBag.Title = "Bookings | Admin";
    var index = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container my-3"">
    <table class=""table table-hover my-3"">
        <thead class=""table-dark"">
            <tr>
                <th>#</th>
                <th>Movie</th>
                <th>User Name</th>
                <th>Email</th>
                <th>Show Date </th>
                <th>Language</th>
                <th>Time</th>
                <th>Seat</th>
                <th>Price</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 26 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Admin\Bookings.cshtml"
             foreach (var booking in Model)
            {
                index++;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 30 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Admin\Bookings.cshtml"
               Write(index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Admin\Bookings.cshtml"
               Write(_movieRepo.GetMovie(booking.Show.MovieId).Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Admin\Bookings.cshtml"
               Write(booking.IdentityUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Admin\Bookings.cshtml"
               Write(booking.IdentityUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Admin\Bookings.cshtml"
               Write(DateTime.Parse(booking.ShowDate).ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Admin\Bookings.cshtml"
               Write(booking.Show.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Admin\Bookings.cshtml"
               Write(booking.Show.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Admin\Bookings.cshtml"
               Write(booking.SeatNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Admin\Bookings.cshtml"
               Write(booking.Show.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₹</td>\r\n            </tr>\r\n");
#nullable restore
#line 40 "D:\Projects\.NetCore\MovieTicketBooking\MovieTicketBooking\Views\Admin\Bookings.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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