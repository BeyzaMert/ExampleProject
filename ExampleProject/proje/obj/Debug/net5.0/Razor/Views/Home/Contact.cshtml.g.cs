#pragma checksum "C:\Users\beyza\source\repos\proje\proje\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fff4040bf059e01a81b370e9425e2a6995f7aac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fff4040bf059e01a81b370e9425e2a6995f7aac", @"/Views/Home/Contact.cshtml")]
    #nullable restore
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/iconn-grid.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/form-contact.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\beyza\source\repos\proje\proje\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7fff4040bf059e01a81b370e9425e2a6995f7aac4076", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7fff4040bf059e01a81b370e9425e2a6995f7aac5190", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<style>
  

  


        .containerr{
            width:100%;
            height:100vh;
            display:flex;
            align-items:center;
            justify-content:center;
            flex-direction:column;
        }

        iframe{
            width:100%;
            height:70% ;
            
        }

    .logo-slider .slider-inner .logo-slide-img img {
        cursor: pointer;
        pointer-events: auto;
    }

    .logo-slider .slider-inner .logo-slide-img {
        height: 100%;
        text-align: center;
        padding: 3rem;
    }

    .logo-slider {
        position: absolute;
        /*        top:30%;
    */ left: 0%;
        width: 100%;
        height: 200px;
        overflow: hidden;
        background-color: #f7f7f7;
    }

    .slider-inner {
        position: absolute;
        top: 0;
        left: 0;
        height: 100%;
        width: 200%;
        display: grid;
        grid-template-columns: repeat(7,1fr);
        gap: 5px;
  ");
            WriteLiteral("      pointer-events: none;\r\n        transition: 0s ease-in;\r\n    }\r\n</style>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fff4040bf059e01a81b370e9425e2a6995f7aac7447", async() => {
                WriteLiteral(@"

    <div class=""common-section"">
        
        <h1>Contact Us</h1>
        <h2>FEEL FREE TO SEND US A MESSAGE NOW!</h2>
        
    </div>

   
    <div class=""container"">
        <div class=""slide-two"">
            <i class=""fa-solid fa-phone""></i>
            <div class=""info"">
                <h3>Phone</h3>
                <p class=""text""> Vivamus ut tellus mi. Nulla nec cursus elit, id vulputate nec cursus augue. </p>
                <p class=""textbtn"" >090-080-0760</p>
            </div>
        </div>

        <div class=""slide-two "">
            <i class=""fa-solid fa-envelope""></i>
            <div class=""info"">
                <h3>Email</h3>
                <p> Vivamus ut tellus mi. Nulla nec cursus elit, id vulputate nec cursus augue. </p>
                <p class=""textbtn"">info@company.com</p>
            </div>
        </div>

        <div class=""slide-two "">
            <i class=""fa-solid fa-location-dot""></i>
            <div class=""info"">
                <h3");
                WriteLiteral(@">Location </h3>
                <p>
                    1020 New Mountain Street
                    Forest Park, FP 11220
                </p>
                <p class=""textbtn""> View on Google Maps</p>
            </div>
        </div>
    </div>
       
    	<div class=""callback"">
        <div class=""top"">
            <h1 class=""aboutus-text"">Send us a  <span> message </span> </h1>
        <h3 class=""aboutus-text-two"">SUSPENDISSE A ANTE IN NEQUE IACULIS LACINIA</h3>
        </div>
		<form action=""/Home/Index"" method=""post"">
			<div class=""half"">


				<div class=""item"">
					<input name=""Name"" type=""text"" id=""name"" placeholder=""Full Name"" />	
				</div>


				<div class=""item"">
					<input name=""Email"" type=""text"" id=""name"" placeholder=""E-Mail Address"" />
				</div>

				<div class=""item"">
					<input name=""Subject"" type=""text"" id=""name"" placeholder=""Subject"" />
				</div>
			</div>
			<div class=""textarea-design"">
				<div class=""item"">
					<textarea name=""Message"" id=""m");
                WriteLiteral(@"essage"" placeholder=""Your Message""></textarea>
				</div>
			</div>
			<div class=""action"">
				<input type=""submit"" value="" Send Message"" />
			</div>

        </form>
    </div>
  


   <div class=""containerr"">
        <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d201550.3917781631!2d32.366398016049104!3d37.87842350751262!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14d08568d615f745%3A0x240dd0fc08060967!2sKonya!5e0!3m2!1str!2str!4v1679398128932!5m2!1str!2str"" width=""600"" height=""450"" style=""border:0;""");
                BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 3912, "\"", 3930, 0);
                EndWriteAttribute();
                WriteLiteral(@" loading=""lazy"" referrerpolicy=""no-referrer-when-downgrade""></iframe>
    
   </div>

    <div class=""logo-slider"">
        <div class=""slider-inner"">
            <div class=""logo-slide-img"">
                <img src=""/web/img/client-01.png"" />
            </div>

            <div class=""logo-slide-img"">
                <img src=""/web/img/client-01.png"" />
            </div>

            <div class=""logo-slide-img"">
                <img src=""/web/img/client-01.png"" />
            </div>

            <div class=""logo-slide-img"">
                <img src=""/web/img/client-01.png"" />
            </div>

            <div class=""logo-slide-img"">
                <img src=""/web/img/client-01.png"" />
            </div>

            <div class=""logo-slide-img"">
                <img src=""/web/img/client-01.png"" />
            </div>
            <div class=""logo-slide-img"">
                <img src=""/web/img/client-01.png"" />
            </div>
        </div>
    </div>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>

    let slider = document.querySelector('.logo-slider');
    let innerSlider = document.querySelector('.slider-inner');

    let pressed = false;
    let startx;
    let x;

    slider.addEventListener('mousedown', (e) => {
        pressed = true;
        startx = e.offsetX - innerSlider.offsetLeft;
        slider.style.cursor = 'grabbing'
    });

    slider.addEventListener('mouseenter', () => {
        slider.style.cursor = 'grab'
    })

    //slider.addEventListener('mouseleave', () => {
    //    slider.style.cursor = 'default'
    //});

    slider.addEventListener('mouseup', () => {
        slider.style.cursor = 'grab'
    });

    window.addEventListener('mouseup', () => {
        pressed = false;
    });

    slider.addEventListener('mousemove', (e) => {
        if (!pressed) return;
        e.preventDefault();

        x = e.offsetX

        innerSlider.style.left = `${x - startx}px`;

        //checkboundary()
    });

    //function checkbou");
            WriteLiteral(@"ndary(){
    //    let outer=slider.getBoundingClientRect();
    //    let inner= innerSlider.getBoundingClientRect();

    //    if(parseInt(innerSlider.style.left)>0){
    //        innerSlider.style.left='0px';
    //        } else if (inner.right < outer.right) {
    //            innerSlider.style.left=`-${inner.width-outer.width}px`
    //        }
    //}

    //checkboundary()

    // </script>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
