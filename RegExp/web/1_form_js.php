<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
	<head>
		<title>����������� ������������</title>
		<script type="text/javascript" src="jquery-1.11.0.min.js"></script>
		<script type="text/javascript">
			$(function() {
				//alert("Ready");
				$("#Send").click(function()
				{
					//alert("clicked");
					//if("".test($))
					//var pattern = /.*/;var f_username=$("#f_username").val();
					
					var email_pattern = /^[A-Za-z0-9\._-]+@[A-Za-z0-9_-]+\.[A-Za-z0-9_-]+$/;
					var phone_pattern = /^[0-9+]{0,15}$/;
					var site_pattern = /^[A-Za-z�-��-�0-9\.\?\&_\-\/\:]*$/;
					var age_pattern = /^[0-9]+$/;
					
					var error="";
					
					if($.trim($("#f_username").val())=="")
					{
						$("#f_username").css("border-color","#F00");
						error+="- ������������ ���� \"��� ������������\" �� ���������! <br/>";
					}
					else
						$("#f_username").css("border-color","");
						
					if(!email_pattern.test($("#f_email").val()))
						{
							$("#f_email").css("border-color","#F00");
							error+="- ���� \"Email\" �������� ������������ �������! <br/>";
						}
					else
						$("#f_email").css("border-color","");
					
					if(!site_pattern.test($("#f_site").val()))	
						{
							$("#f_site").css("border-color","#F00");
							error+="- ���� \"����\" �������� ������������ �������! <br/>";
						}
					else
						$("#f_site").css("border-color","");
						
					if(!phone_pattern.test($("#f_phone").val()))
						{
							$("#f_phone").css("border-color","#F00");
							error+="- ���� \"�������\" �������� ������������ �������! <br/>";
						}
					else
						$("#f_phone").css("border-color","");
					
					if(age_pattern.test($("#f_age").val()) && parseInt($("#f_age").val()) >= 18 && parseInt($("#f_age").val())<=150)					
						$("#f_age").css("border-color","");					
					else
						{
							$("#f_age").css("border-color","#F00");
							error+="- ���� \"�������\" ������ ���� �� 18 �� 150! <br/>";
						}
					
					if($.trim(error)!="")
						{
							$("#error").html(error);
							return false;
						}
				});
			});
		</script>
	</head>
	<body>
		<form action="" method="POST">			
			<b>��� ������������:</b><br/>
			<input id="f_username" name="f_username" type="text" size="50"/><br/>
			<b>Email:</b><br/>
			<input id="f_email" name="f_email" type="text" size="15"/><br/>
			<b>����:</b><br/>
			<input id="f_site" name="f_site" type="text" size="57"/><br/>
			<b>�������:</b><br/>
			<input id="f_phone" name="f_phone" type="text" size="25"/><br/>
			<b>�������:</b><br/>
			<input id="f_age" name="f_age" type="text" size="50"/><br/>
			<b>�������������:</b><br/>
			<textarea id="f_about" name="f_about" rows="5" cols="50"></textarea><br/>
			<div id="error" style="color: #F00"></div>
			<input id="Send" name="Send" type="Submit" value="���������"/>
		</form>
	</body>
</html>