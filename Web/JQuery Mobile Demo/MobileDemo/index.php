<?php
require_once 'Mobile_Detect.php';
$detect = new Mobile_Detect;
 
// Any mobile device (phones or tablets).

if ($detect->isMobile()) 
  
{
               header( 'Location: mobi/index.html' ) ;
}
        

// not a mobile device
else
  
{
echo ("<p>This would be the desktop version of the site.You have been directed to this page ");
echo ("by a PHP script which knows that you are using a desktop computer to access this webpage.<br/>");
echo ("Please open this URL on a mobile device to see the jquery sample site. I guess if you ");
echo ("really want to, you can see the sample on your ");
echo ("<a href='mobi/index.html' computer> (it will not be as pretty)</p>");
}        
 
// Any tablet device.
if( $detect->isTablet() ){
 
}
 
// Exclude tablets.
if( $detect->isMobile() && !$detect->isTablet() ){
 
}
 
// Check for a specific platform with the help of the magic methods:
if( $detect->isiOS() ){
 
}
 
if( $detect->isAndroidOS() ){
 
}
?>