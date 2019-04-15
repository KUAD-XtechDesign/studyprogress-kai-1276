@charset "UTF-8";

body{
  box-sizing: border-box;
  margin: 0;
  min-height: 100vh;
  display: grid;
  grid-template-columns: 180px 1fr 270px;
  grid-template-rows: 120px 65px 1fr 20px;
  grid-template-areas:
  " header  header   header"
  " nav     nav      nav   "
  " Lside   main     Rside "
  " footer  footer   footer";
}



header{
  grid-area: header;
}



nav{
  grid-area: nav;
  position: -webkit-sticky;
  left: 0;
  top: 0;
  width: 100%;
  background: #000b00;
  border-bottom: 5px solid #00ffff;
}
nav ul{
  list-style: none;
  display: flex;
  flex-flow: row;
  margin: 0;
  padding: 20px 10px 0 10px;
}
nav li a{
  display: block;
  padding: 10px 20px;
  text-decoration: none;
  font-size: 14px;
  color: #ffffff;
}
nav li a:hover{
  background: #00ffff;
  border-radius: 10px 10px 0 0;
}
nav li.students{
  margin-left: auto;
}



main{
  grid-area: main;
  z-index: 0;
}



aside{
  z-index: 0;
}



#lside{
  grid-area: Lside;
}



#rside{
  grid-area: Rside;
}



footer{
  grid-area: footer;
  position: fixed;
  display: flex;
  z-index: 10;
  bottom: 0;
  width: 100%;
  background-color: #000b00;
  border-top: 5px solid #00ffff;
}
.breadcrump{
  margin: 0;
  list-style: none;
  padding: 3px 20px 0px;
  font-size: 14px;
}
.breadcrump li{
  display: inline-block;
  color: #ffffff;
}
.breadcrump li::after{
  content: ">>";
  padding: 0.5px;
  color: #00ffff;
}
.breadcrump li.last{
  content: none;
}
.breadcrump li:first-child{
  margin-left: auto;
}
.breadcrump li:first-child::after{
  content: "â†’";
  color: #00ffff;
}
.breadcrump li:last-child::after{
  content: none;
}



figure.image-box{
  float: left;
  padding-right: 20px;
}

.clear{
  clear:both;
}

p{
  letter-spacing: 1px;
  line-height: 30px;
  max-width: 640px;
}
.lead::first-letter{
  float:left;
  padding:0.05em 0.05em 0 0;
  line-height: 0.95em;
  font-size: 4.1em;
  font-weight: bold;
}
:target{
  background: #0000ff;
}

a{
  text-decoration: none;
}
a:link{
  color: #00a1e9;
}
a:visited{
  color: #5bad92;
}
a:hover{
  opacity: 0.75;
  text-decoration: underline;
}

::selection{
  background-color: #00ffff;
}
