<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="Client.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    font-family: 'Poppins', sans-serif;
}

body {
    display: flex;
    min-height: 100vh;
    background-color: #eef1f4;
}

.navigation {
  width: 260px;
  background: radial-gradient(circle at top left, #143d63, #03111e);
  padding: 25px 15px;
  height: 100vh;
  position: fixed;
  color: white;
  display: flex;
  flex-direction: column;
  align-items: center;
  box-shadow: 3px 0 15px rgba(0,0,0,0.2);
}

.navigation h2 {
  font-size: 20px;
  text-transform: uppercase;
  margin-bottom: 30px;
  font-weight: bold;
  letter-spacing: 2px;
  position: relative;
  padding-bottom: 10px;
  text-align: center;
}

.navigation h2:after {
  content: "";
  position: absolute;
  bottom: 0;
  left: 50%;
  transform: translateX(-50%);
  height: 3px;
  width: 60px;
  background: linear-gradient(90deg, transparent, #4facfe, transparent);
}

.navbar {
  width: 100%;
  list-style: none;
  padding: 0;
}

.navbar li {
  width: 100%;
  margin-bottom: 12px;
}

.nav_main{
 display: flex;
 font-weight: bold;
 background: transparent;
 color: #e0e0e0;
 transition: all 0.25s ease;
 position: relative;
 overflow: hidden;
 font-size:30px;
 margin-bottom:20px
}

.navbar li a {
  display: flex;
  align-items: center;
  text-decoration: none;
  background: transparent;
  color: #e0e0e0;
  padding: 12px 15px;
  border-radius: 0;
  transition: all 0.25s ease;
  font-weight: 500;
  border-left: 3px solid transparent;
  position: relative;
  overflow: hidden;
  font-size:18px;
  margin-bottom:25px
}

.navbar li a:before {
  content: "";
  position: absolute;
  top: 0;
  left: 0;
  width: 0;
  height: 100%;
  background: rgba(79, 172, 254, 0.1);
  transition: width 0.3s ease;
  z-index: -1;
}

.navbar li a:hover {
  background: transparent;
  transform: translateX(5px);
  color: white;
  border-left: 3px solid #4facfe;
}

.navbar li a:hover:before {
  width: 100%;
}

.Dashboard_main {
    margin-left: 280px;
    padding: 25px;
    width: calc(100% - 280px);
}

.Dashboard_main h1 {
    background: radial-gradient(circle at top left, #143d63, #03111e);
    padding: 20px;
    border-radius: 10px;
    font-size: 44px;
    font-weight: bold;
    color: white;
    text-align: center;
    box-shadow: 0 6px 12px rgba(0, 0, 0, 0.15);
    text-transform: uppercase;
    letter-spacing: 1.5px;
    position: relative;
    overflow: hidden;
}

.Dashboard_main h1::before {
    content: "";
    position: absolute;
    top: 50%;
    left: 50%;
    width: 120%;
    height: 120%;
    background: radial-gradient(circle, rgba(255, 255, 255, 0.15) 10%, transparent 70%);
    transform: translate(-50%, -50%);
    opacity: 0;
    transition: opacity 0.3s ease-in-out;
}

.Dashboard_main h1:hover::before {
    opacity: 1;
}

.Dashboard_main h1::after {
    content: "";
    display: block;
    width: 80px;
    height: 4px;
    background: white;
    margin: 12px auto 0;
    border-radius: 2px;
}

.main {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(320px, 1fr));
    gap: 20px;
    padding: 20px;
}

.main h2 {
    grid-column: 1 / -1;
    margin-bottom: 10px;
    color: #333;
    font-size: 26px;
    font-weight: bold;
    text-align: center;
    text-transform: uppercase;
}

.main h3 {
    grid-column: 1 / -1;
    background: radial-gradient(circle at top left, #143d63, #03111e);
    padding: 12px;
    border-radius: 8px;
    font-size: 42px;
    font-weight: bold;
    color: white;
    text-align: center;
    box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
}
.card {
    grid-column: 1 / -1;
    background: linear-gradient(135deg, #e0f2f1, #2f85a2);
    padding: 30px;
    border-radius: 12px;
    box-shadow: 0 8px 16px rgba(0, 0, 0, 0.15);
    text-align: center;
    transition: transform 0.3s ease-in-out, box-shadow 0.3s ease-in-out;
    border: none;
    position: relative;
    overflow: hidden;
}

.card:hover {
    transform: translateY(-5px);
    box-shadow: 0 10px 20px rgba(0, 0, 0, 0.15);
}

.card h2 {
    color: #05202f;
    font-size: 24px;
    margin-bottom: 12px;
    font-weight: bold;
}

.card p {
    font-size: 20px;
    color: #0b0808;
    margin-bottom: 15px;
    line-height: 1.5;
    font-weight: bold;
}


</style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="navigation">
            <nav>
            <ul class="navbar">
            <li class="nav_main">SPC</li>
            <li><a href="Dashboard.aspx">Home</a></li>
            <li><a href="SupplierForm.aspx">Supplier Registration</a></li>
            <li><a href="PharmacyForm.aspx">New Pharmacy Registration</a></li>
            <li><a href="Login.aspx">Sign In</a></li>
            </ul>
</nav>
        </div>

        <div class="Dashboard_main">
            <h1>Welcome to the SPC</h1>
       
        <div class="main">
            
            <h2>Your trusted partner in pharmaceutical drug manufacturing, distribution, and supply solutions.</h2>
            <br />
            <h3>Our Services</h3>
            <br />
            <div class="card">
                <h2>Supplier Registration</h2>
                <p>Register new suppliers.</p>
            </div>
            <div class="card">
                <h2>Stock Management</h2>
                <p>Search stock details from the main warehouses.</p>
            </div>
            <div class="card">
                <h2>Order Management</h2>
                <p>Order drugs from the main warehouse.</p>
            </div>
            <div class="card">
                <h2>Pharmacy Network</h2>
                <p>New Pharmacies can be registered</p>
            </div>
        </div>

    </div>

    </form>
</body>
</html>
