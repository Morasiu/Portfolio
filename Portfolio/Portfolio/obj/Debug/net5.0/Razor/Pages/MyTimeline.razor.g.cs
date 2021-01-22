#pragma checksum "D:\Projekty\Portfolio\Portfolio\Portfolio\Pages\MyTimeline.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "231c9875dd2d28dae7a3ce156f93036f302bd1a6"
// <auto-generated/>
#pragma warning disable 1591
namespace Portfolio.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Portfolio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Portfolio.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Portfolio.Components.Projects;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projekty\Portfolio\Portfolio\Portfolio\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projekty\Portfolio\Portfolio\Portfolio\Pages\MyTimeline.razor"
using BlazorTimeline;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/MyTimeline")]
    public partial class MyTimeline : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<BlazorTimeline.Timeline>(0);
            __builder.AddAttribute(1, "Title", "My Career");
            __builder.AddAttribute(2, "TitleColor", "#FFFFFF");
            __builder.AddAttribute(3, "TitleBgColor", "#554DE0");
            __builder.AddAttribute(4, "TextColor", "#FFFFFF");
            __builder.AddAttribute(5, "TextBgColor", "#121212");
            __builder.AddAttribute(6, "ItemPositionOption", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorTimeline.ItemPositionOption>(
#nullable restore
#line 10 "D:\Projekty\Portfolio\Portfolio\Portfolio\Pages\MyTimeline.razor"
                              ItemPositionOption.AutoAltering

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<BlazorTimeline.TimelineItem>(8);
                __builder2.AddAttribute(9, "Title", "The story still continues...");
                __builder2.AddAttribute(10, "Time", "Now");
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(12, "\r\n        I\'m still learning new stuff. Working on some cool things and enjoying programming!\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n    ");
                __builder2.OpenComponent<BlazorTimeline.TimelineItem>(14);
                __builder2.AddAttribute(15, "Title", "1st Place Hackathon Sheep Your Hack 2");
                __builder2.AddAttribute(16, "Time", "17.11.2020");
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(18, @"
        I've attended SheepYourHack 2 hackthon with two of mine friends and won.
        We've made an app called web Printy, which solves the problem of difficult access to printing spots.
        I was reposonsible for making REST API using .Net Core.
        ");
                    __builder3.AddMarkupContent(19, "<div class=\"img-container\" b-luecnk7vtn><img src=\"Images/Achievements/sheep_your_hack.png\" alt=\"SheepYourHack2 logo\" b-luecnk7vtn></div>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n    ");
                __builder2.OpenComponent<BlazorTimeline.TimelineItem>(21);
                __builder2.AddAttribute(22, "Title", "My first article");
                __builder2.AddAttribute(23, "Time", "17.09.2020");
                __builder2.AddAttribute(24, "ButtonText", "LINK");
                __builder2.AddAttribute(25, "Link", "https://bulldogjob.pl/news/1294-tworzenie-biblioteki-do-web-api-w-net");
                __builder2.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(27, @"
        I've written an article about creating Web API client in .Net and it was published on popular 
        programming site called BulldogJob. I've used Restsharp as an example of the helper library.
        It contained integrations tests guide, publishing packages to nuget and more.
        ");
                    __builder3.AddMarkupContent(28, "<div class=\"img-container\" b-luecnk7vtn><img src=\"Images/Achievements/BulldogJob_logo.png\" alt=\"Article image\" b-luecnk7vtn></div>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n    ");
                __builder2.OpenComponent<BlazorTimeline.TimelineItem>(30);
                __builder2.AddAttribute(31, "Title", "Code Hydra");
                __builder2.AddAttribute(32, "Time", "05.2019");
                __builder2.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(34, "\r\n        I\'ve founded my own company called Cody Hydra and became self-employed.\r\n        ");
                    __builder3.AddMarkupContent(35, "<div class=\"img-container\" b-luecnk7vtn><img src=\"Images/Companies/codehydra_full_logo.png\" alt=\"Code hydra logo\" b-luecnk7vtn></div>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\r\n    ");
                __builder2.OpenComponent<BlazorTimeline.TimelineItem>(37);
                __builder2.AddAttribute(38, "Title", "TapTake startup");
                __builder2.AddAttribute(39, "Time", "05.2019");
                __builder2.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(41, "\r\n        I quit Tronel to work with a startup on app called TapTake. It was a shopping platform foccused on small and\r\n        medium stores. I was reposponsible for making a REST API using .Net Core, managing cloud and database.\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n    ");
                __builder2.OpenComponent<BlazorTimeline.TimelineItem>(43);
                __builder2.AddAttribute(44, "Title", "Software Engineer at Tronel");
                __builder2.AddAttribute(45, "Time", "01.2019");
                __builder2.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(47, "\r\n        I quit Qumak and started working at the middle programming position at Tronel.\r\n        I was responsible for maintaining the WinForms and WPF desktop application.\r\n        My main tasks were:\r\n        ");
                    __builder3.AddMarkupContent(48, @"<ul b-luecnk7vtn><li b-luecnk7vtn>Implementing new features based on technical documentation</li>
            <li b-luecnk7vtn>Cooperating with a worldwide team,</li>
            <li b-luecnk7vtn>Fixing bugs</li>
            <li b-luecnk7vtn>Writing documentation</li></ul>
        ");
                    __builder3.AddMarkupContent(49, "<div class=\"img-container\" b-luecnk7vtn><img src=\"Images/Companies/tronel.png\" alt=\"Tronel logo\" b-luecnk7vtn></div>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n    ");
                __builder2.OpenComponent<BlazorTimeline.TimelineItem>(51);
                __builder2.AddAttribute(52, "Title", "Change to Junior Programmer");
                __builder2.AddAttribute(53, "Time", "04.2018");
                __builder2.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(55, "\r\n        Even I already was programming in my job, my position name didn\'t reflect that. So I\'ve got myself\r\n        the position name change to Junior Programmer.\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\r\n    ");
                __builder2.OpenComponent<BlazorTimeline.TimelineItem>(57);
                __builder2.AddAttribute(58, "Title", "Started attending WSEI");
                __builder2.AddAttribute(59, "Time", "10.2017");
                __builder2.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(61, "\r\n        I\'ve started external studies at WSEI. My major was Information Technology.\r\n        ");
                    __builder3.AddMarkupContent(62, "<div class=\"img-container\" b-luecnk7vtn><img src=\"Images/Schools/wsei.png\" alt=\"WSEI logo\" b-luecnk7vtn></div>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(63, "\r\n    ");
                __builder2.OpenComponent<BlazorTimeline.TimelineItem>(64);
                __builder2.AddAttribute(65, "Title", "My first programming job");
                __builder2.AddAttribute(66, "Time", "07.2017");
                __builder2.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(68, "\r\n        After I\'ve won the hackathon I got a job offer as Junior Solutions Engineer for a company called Qumak.\r\n        I wrote multiple Python apps for our QumakOS (Arch-based Linux distro). For example:\r\n        ");
                    __builder3.AddMarkupContent(69, @"<ul b-luecnk7vtn><li b-luecnk7vtn>Digital Signage system</li>
            <li b-luecnk7vtn>Document trimmer (using OpenCV)</li>
            <li b-luecnk7vtn>Chat app</li>
            <li b-luecnk7vtn>AutoUpadater serivce</li>
            <li b-luecnk7vtn>Push notification app</li></ul>
        ");
                    __builder3.AddMarkupContent(70, "<div class=\"img-container\" b-luecnk7vtn><img src=\"Images/Companies/qumak.png\" alt=\"Qumak logo\" b-luecnk7vtn></div>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\r\n    ");
                __builder2.OpenComponent<BlazorTimeline.TimelineItem>(72);
                __builder2.AddAttribute(73, "Title", "1st place City Coders Płock Hackathon");
                __builder2.AddAttribute(74, "Time", "21.05.2017");
                __builder2.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(76, @"
        I've attended (with two of my friends) my first hackathon just after my final exams. And... I've won!
        I've made an app called TeamUp. It was an app for finding sports partners, teams for competitive games, gym buddies etc.
        I was responsible for making an Android App using Android studio.
        ");
                    __builder3.AddMarkupContent(77, "<div class=\"img-container\" b-luecnk7vtn><img src=\"Images/Achievements/Logo_City_coders_plock.png\" alt=\"City Coders Płock logo\" b-luecnk7vtn></div>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(78, "\r\n    ");
                __builder2.OpenComponent<BlazorTimeline.TimelineItem>(79);
                __builder2.AddAttribute(80, "Title", "My first Android app");
                __builder2.AddAttribute(81, "Time", "06.12.2017");
                __builder2.AddAttribute(82, "ButtonText", "Github");
                __builder2.AddAttribute(83, "Link", "https://github.com/Morasiu/WhatShouldIDo");
                __builder2.AddAttribute(84, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(85, "\r\n        I\'ve stopped using Unity and started to learn Android app development. I\'ve made a simple project\r\n        called \"What Should I do?\", which was the wheel of fortune app.\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(86, "\r\n    ");
                __builder2.OpenComponent<BlazorTimeline.TimelineItem>(87);
                __builder2.AddAttribute(88, "Title", "My first game");
                __builder2.AddAttribute(89, "Time", "2016");
                __builder2.AddAttribute(90, "ButtonText", "Monnies");
                __builder2.AddAttribute(91, "Link", "https://assetstore.unity.com/packages/templates/packs/monnie-pet-simulator-91450");
                __builder2.AddAttribute(92, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(93, "\r\n        I\'ve switched to learning game development with Unity and C#. Also, I\'ve made my first game called Moonies.\r\n        And I\'ve sold the project as a pet simulator game template.\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(94, "\r\n    ");
                __builder2.OpenComponent<BlazorTimeline.TimelineItem>(95);
                __builder2.AddAttribute(96, "Title", "Beginnings");
                __builder2.AddAttribute(97, "Time", "2015");
                __builder2.AddAttribute(98, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(99, "\r\n        I\'ve started coding in high school. I attended a programming interest group where\r\n        we were learning basic programming stuff using C++. I\'ve made me first Hello World here!\r\n    ");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591