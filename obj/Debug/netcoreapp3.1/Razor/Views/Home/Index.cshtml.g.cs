#pragma checksum "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe08cb255f611f818ed2aa7838dbc37769b746ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\_ViewImports.cshtml"
using JobHub;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\_ViewImports.cshtml"
using JobHub.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe08cb255f611f818ed2aa7838dbc37769b746ac", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38f86f1abe93baddbc70bbdb19dcadb6a3a92a2d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<IndexView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dezPlaceAni"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Browse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Job", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("site-button button-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "JobDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("site-button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Home\Index.cshtml"
  
	bool isSigned = sigin.IsSignedIn(User);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""dez-bnr-inr dez-bnr-inr-md"" style=""background-image:url(/assets/images/main-slider/slide2.jpg);"">
            <div class=""container"">
                <div class=""dez-bnr-inr-entry align-m"">
					<div class=""find-job-bx"">
						<a href=""error-404.html"" class=""site-button button-sm"">Find Jobs, Employment & Career Opportunities</a>
						<h2>Search Between More Then <br/> <span class=""text-primary"">");
#nullable restore
#line 12 "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Home\Index.cshtml"
                                                                                 Write(ViewBag.totaljobs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> Open Jobs.</h2>\r\n\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe08cb255f611f818ed2aa7838dbc37769b746ac7085", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t\t\t<div class=\"col-lg-9 col-md-6\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group\">\r\n\t\t\t\t\t\t\t\t\t\t<label>Job Title, Keywords, or Phrase</label>\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"input-group\">\r\n\t\t\t\t\t\t\t\t\t\t\t<input type=\"text\" class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 896, "\"", 910, 0);
                EndWriteAttribute();
                WriteLiteral(@">
											<div class=""input-group-append"">
											  <span class=""input-group-text""><i class=""fa fa-search""></i></span>
											</div>
										</div>
									</div>
								</div>


								<div class=""col-lg-3 col-md-6"">
									<button type=""submit"" href=""error-404.html"" class=""site-button btn-block"">Find Job</button>
								</div>
							</div>
						");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
					</div>
				</div>
            </div>
        </div>
		<!-- Section Banner END -->
        <!-- About Us -->
		<div class=""section-full job-categories content-inner-2 bg-white"">
			<div class=""container"">
				<div class=""section-head d-flex head-counter clearfix"">
					<div class=""mr-auto"">
						<h2 class=""m-b5"">Popular Categories</h2>
						<h6 class=""fw3"">20+ Catetories work wating for you</h6>
					</div>
					<div class=""head-counter-bx"">
						<h2 class=""m-b5 counter"">");
#nullable restore
#line 47 "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Home\Index.cshtml"
                                            Write(ViewBag.totaljobs);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
						<h6 class=""fw3"">Jobs Posted</h6>
					</div>

				</div>
				<div class=""row sp20"">
					<div class=""col-lg-3 col-md-6 col-sm-6"">
						<div class=""icon-bx-wraper"">
							<div class=""icon-content"">
								<div class=""icon-md text-primary m-b20""><i class=""ti-location-pin""></i></div>
								<a href=""company-manage-job.html"" class=""dez-tilte"">Design, Art & Multimedia</a>
								<p class=""m-a0"">198 Open Positions</p>
								<div class=""rotate-icon""><i class=""ti-location-pin""></i></div>
							</div>
						</div>
					</div>
					<div class=""col-lg-3 col-md-6 col-sm-6"">
						<div class=""icon-bx-wraper"">
							<div class=""icon-content"">
								<div class=""icon-md text-primary m-b20""><i class=""ti-wand""></i></div>
								<a href=""company-manage-job.html"" class=""dez-tilte"">Education Training</a>
								<p class=""m-a0"">198 Open Positions</p>
								<div class=""rotate-icon""><i class=""ti-wand""></i></div>
							</div>
						</div>
					</div>
					<div class=""col-lg-3 col-");
            WriteLiteral(@"md-6 col-sm-6"">
						<div class=""icon-bx-wraper"">
							<div class=""icon-content"">
								<div class=""icon-md text-primary m-b20""><i class=""ti-wallet""></i></div>
								<a href=""company-manage-job.html"" class=""dez-tilte"">Accounting / Finance</a>
								<p class=""m-a0"">198 Open Positions</p>
								<div class=""rotate-icon""><i class=""ti-wallet""></i></div>
							</div>
						</div>
					</div>
					<div class=""col-lg-3 col-md-6 col-sm-6"">
						<div class=""icon-bx-wraper"">
							<div class=""icon-content"">
								<div class=""icon-md text-primary m-b20""><i class=""ti-cloud-up""></i></div>
								<a href=""company-manage-job.html"" class=""dez-tilte"">Human Resource</a>
								<p class=""m-a0"">198 Open Positions</p>
								<div class=""rotate-icon""><i class=""ti-cloud-up""></i></div>
							</div>
						</div>
					</div>
					<div class=""col-lg-3 col-md-6 col-sm-6"">
						<div class=""icon-bx-wraper"">
							<div class=""icon-content"">
								<div class=""icon-md text-primary m-b20""><i class");
            WriteLiteral(@"=""ti-bar-chart""></i></div>
								<a href=""company-manage-job.html"" class=""dez-tilte"">Telecommunications</a>
								<p class=""m-a0"">198 Open Positions</p>
								<div class=""rotate-icon""><i class=""ti-bar-chart""></i></div>
							</div>
						</div>
					</div>
					<div class=""col-lg-3 col-md-6 col-sm-6"">
						<div class=""icon-bx-wraper"">
							<div class=""icon-content"">
								<div class=""icon-md text-primary m-b20""><i class=""ti-tablet""></i></div>
								<a href=""company-manage-job.html"" class=""dez-tilte"">Restaurant / Food Service</a>
								<p class=""m-a0"">198 Open Positions</p>
								<div class=""rotate-icon""><i class=""ti-tablet""></i></div>
							</div>
						</div>
					</div>
					<div class=""col-lg-3 col-md-6 col-sm-6"">
						<div class=""icon-bx-wraper"">
							<div class=""icon-content"">
								<div class=""icon-md text-primary m-b20""><i class=""ti-camera""></i></div>
								<a href=""company-manage-job.html"" class=""dez-tilte"">Construction / Facilities</a>
								<p class=");
            WriteLiteral(@"""m-a0"">198 Open Positions</p>
								<div class=""rotate-icon""><i class=""ti-camera""></i></div>
							</div>
						</div>
					</div>
					<div class=""col-lg-3 col-md-6 col-sm-6"">
						<div class=""icon-bx-wraper"">
							<div class=""icon-content"">
								<div class=""icon-md text-primary m-b20""><i class=""ti-panel""></i></div>
								<a href=""company-manage-job.html"" class=""dez-tilte"">Health</a>
								<p class=""m-a0"">198 Open Positions</p>
								<div class=""rotate-icon""><i class=""ti-panel""></i></div>
							</div>
						</div>
					</div>
					<div class=""col-lg-12 text-center m-t30"">
						<button class=""site-button radius-xl"">All Categories</button>
					</div>
				</div>
			</div>
		</div>
		<!-- About Us END -->
		<!-- Call To Action -->
		<div class=""section-full content-inner bg-gray"">
			<div class=""container"">
				<div class=""row"">
					<div class=""col-lg-12 section-head text-center"">
						<h2 class=""m-b5"">Featured Cities</h2>
						<h6 class=""fw4 m-b0"">20+ Featured Ci");
            WriteLiteral(@"ties Added Jobs</h6>
					</div>
				</div>
				<div class=""row"">

					<div class=""col-lg-3 col-sm-6 col-md-6 m-b30"">
						<a href=""javascript:void(0);"">
							<div class=""city-bx align-items-end  d-flex"" style=""background-image:url(/assets/images/city/pic5.jpg)"">
								<div class=""city-info"">
									<h5>India</h5>
									<span>765 Jobs</span>
								</div>
							</div>
						</a>
					</div>
					<div class=""col-lg-3 col-sm-6 col-md-6 m-b30"">
						<a href=""javascript:void(0);"">
							<div class=""city-bx align-items-end  d-flex"" style=""background-image:url(/assets/images/city/pic6.jpg)"">
								<div class=""city-info"">
									<h5>Thailand</h5>
									<span>352 Jobs</span>
								</div>
							</div>
						</a>
					</div>
					<div class=""col-lg-3 col-sm-6 col-md-6 m-b30"">
						<a href=""javascript:void(0);"">
							<div class=""city-bx align-items-end  d-flex"" style=""background-image:url(/assets/images/city/pic7.jpg)"">
								<div class=""city-info"">
									<h5");
            WriteLiteral(@">Banjul</h5>
									<span>893 Jobs</span>
								</div>
							</div>
						</a>
					</div>
					<div class=""col-lg-3 col-sm-6 col-md-6 m-b30"">
						<a href=""javascript:void(0);"">
							<div class=""city-bx align-items-end  d-flex"" style=""background-image:url(/assets/images/city/pic8.jpg)"">
								<div class=""city-info"">
									<h5>Spain</h5>
									<span>502 Jobs</span>
								</div>
							</div>
						</a>
					</div>
				</div>
			</div>
		</div>
		<!-- Call To Action END -->
		<!-- Our Job -->
		<div class=""section-full bg-white content-inner-2"">
			<div class=""container"">
				<div class=""d-flex job-title-bx section-head m-b30"">
					<div class=""mr-auto"">
						<h2 class=""m-b5"">Recent Jobs</h2>
						<h6 class=""fw4 m-b0"">20+ Recently Added Jobs</h6>
					</div>
					<div class=""align-self-end"">
						");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe08cb255f611f818ed2aa7838dbc37769b746ac16430", async() => {
                WriteLiteral("Browse All Jobs <i class=\"fa fa-long-arrow-right\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t<div class=\"col-lg-9\">\r\n\t\t\t\t\t\t<ul class=\"post-job-bx browse-job\">\r\n");
#nullable restore
#line 210 "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Home\Index.cshtml"
                             foreach(var x in Model)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t<div class=\"post-bx\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"d-flex m-b30\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"job-post-company\">\r\n\t\t\t\t\t\t\t\t\t\t\t<span><img");
            BeginWriteAttribute("alt", " alt=\"", 8236, "\"", 8242, 0);
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 8243, "\"", 8268, 2);
            WriteAttributeValue("", 8249, "/companies/", 8249, 11, true);
#nullable restore
#line 216 "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Home\Index.cshtml"
WriteAttributeValue("", 8260, x.Image, 8260, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("/></span>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"job-post-info\">\r\n\t\t\t\t\t\t\t\t\t\t\t<h4>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe08cb255f611f818ed2aa7838dbc37769b746ac19200", async() => {
#nullable restore
#line 219 "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Home\Index.cshtml"
                                                                                                                Write(x.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 219 "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Home\Index.cshtml"
                                                                                                  WriteLiteral(x.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h4>\r\n\t\t\t\t\t\t\t\t\t\t\t<ul>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<li><i class=\"fa fa-map-marker\"></i> ");
#nullable restore
#line 221 "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Home\Index.cshtml"
                                                                                Write(x.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<li><i class=\"fa fa-bookmark-o\"></i> ");
#nullable restore
#line 222 "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Home\Index.cshtml"
                                                                                Write(x.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<li><i class=\"fa fa-clock-o\"></i> Posted ");
#nullable restore
#line 223 "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Home\Index.cshtml"
                                                                                    Write(x.PostedOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\t\t\t\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"d-flex\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"job-time mr-auto\">\r\n\t\t\t\t\t\t\t\t\t\t\t<a href=\"javascript:void(0);\"><span>");
#nullable restore
#line 229 "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Home\Index.cshtml"
                                                                           Write(x.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></a>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"salary-bx\">\r\n\t\t\t\t\t\t\t\t\t\t\t<span>");
#nullable restore
#line 232 "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Home\Index.cshtml"
                                             Write(x.MinSalary);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 232 "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Home\Index.cshtml"
                                                            Write(x.MaxSalary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<label class=\"like-btn\">\r\n\t\t\t\t\t\t\t\t\t\t  <input type=\"checkbox\">\r\n\t\t\t\t\t\t\t\t\t\t  <span class=\"checkmark\"></span>\r\n\t\t\t\t\t\t\t\t\t</label>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</li>\r\n");
#nullable restore
#line 241 "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Home\Index.cshtml"
							}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
						</ul>
						<div class=""m-t30"">
							<div class=""d-flex"">
								<a class=""site-button button-sm mr-auto"" href=""javascript:void(0);""><i class=""ti-arrow-left""></i> Prev</a>
								<a class=""site-button button-sm"" href=""javascript:void(0);"">Next <i class=""ti-arrow-right""></i></a>
							</div>
						</div>
					</div>
					<div class=""col-lg-3"">
						<div class=""sticky-top"">
");
#nullable restore
#line 253 "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Home\Index.cshtml"
                             if(!isSigned)
							{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<div class=\"quote-bx\">\r\n\t\t\t\t\t\t\t\t<div class=\"quote-info\">\r\n\t\t\t\t\t\t\t\t\t<h4>Make a Difference with Your Online Resume!</h4>\r\n\t\t\t\t\t\t\t\t\t<p>Your resume in minutes with JobBoard resume assistant is ready!</p>\r\n\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe08cb255f611f818ed2aa7838dbc37769b746ac25611", async() => {
                WriteLiteral("Create an Account");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 263 "C:\Users\gaura\OneDrive\Desktop\JobHub\JobHub\JobHub\Views\Home\Index.cshtml"
							}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<!-- Our Job END -->\r\n\t\t<!-- Call To Action -->\r\n\r\n\t\t<!-- Call To Action END -->\r\n\t\t<!-- Our Latest Blog -->\r\n\r\n\t\t<!-- Our Latest Blog -->\r\n\t</div>\r\n\t<!-- Content END-->\r\n\t<!-- Modal Box -->\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> sigin { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<IndexView>> Html { get; private set; }
    }
}
#pragma warning restore 1591