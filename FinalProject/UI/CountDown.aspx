<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CountDown.aspx.cs" Inherits="FinalProject.UI.CountDown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CountDown</title>
    <link href="../css/countdown.css" rel="stylesheet" />

    <script type="text/javascript">

        var countDownDate = new Date("Apr 12, 2018 22:49:40").getTime();

        var x = setInterval(function () {

            // Get todays date and time
            var now = new Date().getTime();

            // Find the distance between now an the count down date
            var distance = countDownDate - now;

            // Time calculations for days, hours, minutes and seconds
            var days = Math.floor(distance / (1000 * 60 * 60 * 24));
            var hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
            var minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
            var seconds = Math.floor((distance % (1000 * 60)) / 1000);

            // Display the result in the element with id="demo"
            document.getElementById("demo").innerHTML = days + "d " + hours + "h "
            + minutes + "m " + seconds + "s ";

            // If the count down is finished, write some text 
            if (distance < 0) {
                clearInterval(x);
                document.getElementById("demo").innerHTML = "EXPIRED";
                window.location = "SendNotice.aspx";
            }
        }, 1000);

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p runat="server" id="demo"></p>
        </div>
    </form>
</body>
</html>
