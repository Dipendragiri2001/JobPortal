#pragma checksum "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e63bbe05713217018f70759236c47b90c3f34e77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Job_JobDetails), @"mvc.1.0.view", @"/Views/Job/JobDetails.cshtml")]
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
#line 1 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\_ViewImports.cshtml"
using JobHub;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\_ViewImports.cshtml"
using JobHub.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\_ViewImports.cshtml"
using JobsCatalog.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e63bbe05713217018f70759236c47b90c3f34e77", @"/Views/Job/JobDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3482ba852f30749ccce95d4ad9e53d8f89fbd851", @"/Views/_ViewImports.cshtml")]
    public class Views_Job_JobDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobDetailsView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Company", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\t\r\n");
#nullable restore
#line 5 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
      
	bool isSigned = sigin.IsSignedIn(User);
	bool isExpired = Model.IsExpired;
	

#line default
#line hidden
#nullable disable
            WriteLiteral(@"	<div class=""page-content bg-white"">
		<!-- inner page banner -->

		<!-- inner page banner END -->
		<!-- contact area -->
		<div class=""content-block"">
			<!-- Job Detail -->
			<div class=""section-full content-inner-1"">
				<div class=""container"">
					<div class=""row"">
						<div class=""col-lg-4"">
							<div class=""sticky-top"">
								<div class=""row"">
									<div class=""col-lg-12 col-md-6"">
										<ul class=""post-job-bx browse-job"">
											<li>
												<div class=""post-bx"">
													<div class=""d-flex m-b30"">
														<div class=""job-post-company"">

															<span><img");
            BeginWriteAttribute("alt", " alt=\"", 828, "\"", 834, 0);
            EndWriteAttribute();
            BeginWriteAttribute("src", " src=\"", 835, "\"", 863, 2);
            WriteAttributeValue("", 841, "/companies/", 841, 11, true);
#nullable restore
#line 29 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
WriteAttributeValue("", 852, Model.Logo, 852, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></span>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"job-post-info\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<h5>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e63bbe05713217018f70759236c47b90c3f34e775714", async() => {
#nullable restore
#line 33 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
                                                                                        Write(Model.CompanyName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h5>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<ul>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<li><i class=\"fa fa-map-marker\"></i> Birtmode</li>\r\n\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<li><i class=\"fa fa-clock-o\"></i> ");
#nullable restore
#line 37 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
                                                                                             Write(Model.CompanyFounded);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
																</li>
															</ul>
														</div>
													</div>
												</div>
											</li>
										</ul>
									</div>
									<div class=""col-lg-12 col-md-6"">
										<div class=""widget bg-white p-lr20 p-t20  widget_getintuch radius-sm"">
											<h5 class=""text-black font-weight-700 p-t10 m-b15"">Job Details</h5>
											<ul>
												<li><i class=""ti-location-pin""></i><strong
														class=""font-weight-700 text-black"">Address</strong><span
														class=""text-black-light""> ");
#nullable restore
#line 52 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
                                                                             Write(Model.Job.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral(" , ");
#nullable restore
#line 52 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
                                                                                                   Write(Model.Job.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</span></li>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<li><i class=\"ti-money\"></i><strong\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tclass=\"font-weight-700 text-black\">Salary</strong>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 56 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
                                               Write(Model.Job.MinSalary);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 56 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
                                                                      Write(Model.Job.MaxSalary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<li><i class=\"ti-shield\"></i><strong\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tclass=\"font-weight-700 text-black\">Experience</strong>");
#nullable restore
#line 58 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
                                                                                                         Write(Model.Job.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<li><i class=\"ti-time\"></i><strong\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tclass=\"font-weight-700 text-black\">Job\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tType</strong>");
#nullable restore
#line 62 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
                                                                Write(Model.Job.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<li><i class=\"ti-user\"></i><strong\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tclass=\"font-weight-700 text-black\">Openings</strong>");
#nullable restore
#line 64 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
                                                                                                       Write(Model.Job.Opening);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t\t</li>\r\n\t\t\t\t\t\t\t\t\t\t\t\t<li><i class=\"ti-tag\"></i><strong\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tclass=\"font-weight-700 text-black\">Tags</strong>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"dez-post-tags clear\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"post-tags\">\r\n");
#nullable restore
#line 70 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
                                                             foreach (var item in Model.Tags)
															{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a href=\"javascript:void(0);\">");
#nullable restore
#line 72 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
                                                                                     Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n");
#nullable restore
#line 73 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"

															}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
														</div>
												</li>

											</ul>
										</div>
									</div>
								</div>
							</div>
						</div>
						<div class=""col-lg-8"">
							<div class=""job-info-box"">
								<h3 class=""m-t0 m-b10 font-weight-700 title-head"">
									<a href=""javascript:void(0);"" class=""text-secondry m-r30"">");
#nullable restore
#line 88 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
                                                                                         Write(Model.Job.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t\t\t\t</h3>\r\n\t\t\t\t\t\t\t\t<ul class=\"job-info\">\r\n\t\t\t\t\t\t\t\t\t<li><strong>Category</strong> ");
#nullable restore
#line 91 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
                                                             Write(Model.Job.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\t\t\t\t\t\t\t\t\t<li><strong>Deadline:</strong> ");
#nullable restore
#line 92 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
                                                              Write(Model.Job.Deadline);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\t\t\t\t\t\t\t\t\t<li><i class=\"ti-location-pin text-black m-r5\"></i> ");
#nullable restore
#line 93 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
                                                                                   Write(Model.Job.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n\t\t\t\t\t\t\t\t\t<li><i class=\"fa fa-eye\"></i> ");
#nullable restore
#line 94 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
                                                             Write(Model.ViewCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t\t<div class=\"alert alert-warning\">\r\n\t\t\t\t\t\t\t\t  <a class=\"close\" data-dismiss=\"alert\">&times</a>\r\n\t\t\t\t\t\t\t\t   <p>");
#nullable restore
#line 98 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
                                 Write(Model.TimeLeftForDeadline);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t<p class=\"p-t20\">");
#nullable restore
#line 102 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
                                            Write(Model.Job.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 103 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
                                 if(isExpired)
								{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<div class=\"alert alert-danger alert error\">\r\n\t\t\t\t\t\t\t\t  <a class=\"close\" data-dismiss=\"alert\">&times</a>\r\n\t\t\t\t\t\t\t\t   <p>This job is expired</p>\r\n\r\n\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 110 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
								}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t<h5 class=\"font-weight-600\">Responsibilities</h5>\r\n\t\t\t\t\t\t\t\t<div class=\"dez-divider divider-2px bg-gray-dark mb-4 mt-0\"></div>\r\n\t\t\t\t\t\t\t\t<p>");
#nullable restore
#line 114 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
                              Write(Model.Job.Responsibility);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t<h5 class=\"font-weight-600\">Requirements</h5>\r\n\t\t\t\t\t\t\t\t<div class=\"dez-divider divider-2px bg-gray-dark mb-4 mt-0\"></div>\r\n\t\t\t\t\t\t\t\t<p>");
#nullable restore
#line 117 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
                              Write(Model.Job.Requirement);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t\t\t\t\t<h5 class=\"font-weight-600\">Benefits</h5>\r\n\t\t\t\t\t\t\t\t<div class=\"dez-divider divider-2px bg-gray-dark mb-4 mt-0\"></div>\r\n\t\t\t\t\t\t\t\t<ul class=\"list-num-count no-round\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 121 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
                               Write(Model.Job.Benefits);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</ul>\r\n");
#nullable restore
#line 123 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
                                 if(!isExpired)
								{
								

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
                                 if (Model.IsApplied)
								{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<a href=\"#\" class=\"site-button\"> <i class=\"fa fa-briefcase\"> </i> Applied</a>\r\n");
#nullable restore
#line 128 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"

								}
								else
								{


#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<a href=\"#\" title=\"READ MORE\" rel=\"bookmark\" data-toggle=\"modal\" data-target=\"#applyJob\"\r\n\t\t\t\t\t\t\t\t\tclass=\"site-button\"> <i class=\"fa fa-briefcase\"> </i> Apply This Job</a>\r\n");
#nullable restore
#line 135 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
								}

#line default
#line hidden
#nullable disable
#nullable restore
#line 135 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
                                 
								}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<label class=\"like-btn\">\r\n\t\t\t\t\t\t\t\t\t<input type=\"checkbox\" id=\"myCheckbox\" ");
#nullable restore
#line 138 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
                                                                       Write(Model.IsSaved? "checked" : "" );

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
									<span class=""checkmark""></span>
								</label>

							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
		<!-- Job Detail -->
		<!-- Our Jobs -->

		<!-- Content END-->


	</div>
	</div>

	<!-- Modal Box -->
	<div class=""modal fade modal-bx-info"" id=""applyJob"" tabindex=""-1"" role=""dialog"" aria-labelledby=""applyJobTitle""
		aria-hidden=""true"">
		<div class=""modal-dialog"" role=""document"">
			<div class=""modal-content"">
				<div class=""modal-header"">

					<h5 class=""modal-title"">");
#nullable restore
#line 164 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
                                       Write(Model.Job.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\t\t\t\t\t<button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n\t\t\t\t\t\t<span aria-hidden=\"true\">&times;</span>\r\n\t\t\t\t\t</button>\r\n\t\t\t\t</div>\r\n\t\t\t\t<div class=\"modal-body\">\r\n");
#nullable restore
#line 170 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
                     if(isSigned)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<form asp-action=\"ApplyJob\" asp-controller=\"Job\">\r\n\t\t\t\t\t\t<h5 class=\"m-t0\">Do you want to apply for this job?</h5>\r\n\t\t\t\t\t\t<input type=\"hidden\" name=\"jobId\"");
            BeginWriteAttribute("value", " value=\"", 5985, "\"", 6006, 1);
#nullable restore
#line 174 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
WriteAttributeValue("", 5993, Model.Job.Id, 5993, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n\t\t\t\t\t\t<br>\r\n\t\t\t\t\t\t<div class=\"clearfix\">\r\n\t\t\t\t\t\t\t<button type=\"submit\" class=\"btn-primary site-button btn-block\">Yes </button>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</form>\r\n");
#nullable restore
#line 181 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
					}
					else
					{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<div class=\"alert alert-danger alert error\">\r\n\t\t\t\t\t\t\t\t  <a class=\"close\" data-dismiss=\"alert\">&times</a>\r\n\t\t\t\t\t\t\t\t   <p>Click Login  button, 😠</p>\r\n\r\n\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 189 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"

					}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"				</div>
				<div class=""modal-footer"">
					<button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">No</button>
				</div>
			</div>
		</div>
	</div>
	<!-- Modal Box End -->
	<script>
		$(function () {
			$('#myCheckbox').change(function () {
				alert(""OK"");



				$.ajax({
					url: '/Job/Save?jobId=' + ");
#nullable restore
#line 207 "C:\Users\Gaurav\Desktop\CGitHub\jobscatalog\JobsCatalog\Views\Job\JobDetails.cshtml"
                                         Write(Model.Job.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
					true,
					cache: false,
					method: 'GET',
					success: function (response) {
						Snackbar.show({
								text: 'Success',
								backgroundColor: ""black"",
								textColor: ""white"",
								actionText: ""Dismiss""
							}

						);
					},
					error: function () {
						Snackbar.show({
								text: 'woops something went wrong',
								backgroundColor: ""black"",
								textColor: ""white"",
								actionText: ""Dismiss""
							}

						);
					}
				});
			});
		});
	</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JobDetailsView> Html { get; private set; }
    }
}
#pragma warning restore 1591