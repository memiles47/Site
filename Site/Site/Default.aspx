﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Site.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            color: #CC0000;
        }
        .Introduction {
            font-style: italic;
            color: #003399;
        }
    </style>
    <link href="Styles/Styles.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/modernizr-2.8.3.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div id ="PageWrapper">
        <header>Header Goes Here</header>
        <nav>Menu Goes Here</nav>
        <section id ="MainContent">
            <h1 style="padding: 0; margin: 0 0 10px 0">Hi there visitor and welcome to Planet Wrox</h1>
            <p class="Introduction">
            We&#39;re glad you&#39;re <span class="auto-style1">paying a visit</span> to <a href="http://www.PlanetWrox.com">www.PlanetWrox.com</a>, the coolest music community site on the Internet.</p>
            <p>
            Feel free to have a <a href="Default.aspx">look around</a>; there are lots of interesting <strong>reviews and concert pictures</strong> to be found here.</p>
        </section>
        <aside id="Sidebar">Sidebar Goes Here</aside>
        <footer>Footer Goes Here</footer>
    </div>
    </form>
</body>
</html>
