<?php
	$msg= "";
	if(isset($_POST["Send"]))
	{
	
		$error="";$wrong=Array();
		if($_POST["js_supported"]=="no")
		{
			$email_pattern="/^[A-Za-z0-9\._-]+@[A-Za-z0-9_-]+\.[A-Za-z0-9_-]+$/";
			$phone_pattern = "/^[0-9+]{0,15}$/";
			$site_pattern = "/^[A-Za-zА-Яа-яЁё0-9\.\?\&_\-\/\:]*$/";
			$age_pattern = "/^[0-9]+$/";
			
			if(trim($_POST["f_username"])=="")
			{
				$wrong[]="#f_username";
				$error.="- [PHP] Обязательное поле \"Имя пользователя\" не заполнено! <br/>";
			}		
				
			if(!preg_match($email_pattern,$_POST["f_email"]))
				{
					$wrong[]="#f_email";
					$error.="- [PHP] Поле \"Email\" содержит недопустимые символы! <br/>";
				}		
			
			if(!preg_match($site_pattern,$_POST["f_site"]))	
				{
					$wrong[]="#f_site";
					$error.="- [PHP] Поле \"Сайт\" содержит недопустимые символы! <br/>";
				}
						
			if(!preg_match($site_pattern,$_POST["f_phone"]))
				{
					$wrong[]="#f_phone";
					$error.="- [PHP] Поле \"Телефон\" содержит недопустимые символы! <br/>";
				}		
			
			if(!(preg_match($age_pattern,$_POST["f_age"]) && (int)$_POST["f_age"] >= 18 && (int)$_POST["f_age"]<=150))		
				{
					$wrong[]="#f_age";
					$error.="- [PHP] Поле \"Возраст\" должно быть от 18 до 150! <br/>";
				}
		}
		
		if(trim($error)=="")
		{
			$msg = "Форма введена корректно, приступаем к обработке";
		}
	}
?>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
	<head>
		<title>Регистрация пользователя</title>
		<? if(trim($error)!=""): ?>
		<style>
			<?=implode(",",$wrong)?>
			{
				border-color: #F00;
			}
		</style>
		<? endif; ?>
		<script type="text/javascript" src="jquery-1.11.0.min.js"></script>
		<script type="text/javascript">
			$(function() {				
				$("#js_supported").val("yes");
				$("#Send").click(function()
				{
					var email_pattern = /^[A-Za-z0-9\._-]+@[A-Za-z0-9_-]+\.[A-Za-z0-9_-]+$/;
					var phone_pattern = /^[0-9+]{0,15}$/;
					var site_pattern = /^[A-Za-zА-Яа-я0-9\.\?\&_\-\/\:]*$/;
					var age_pattern = /^[0-9]+$/;
					
					var error="";
					
					if($.trim($("#f_username").val())=="")
					{
						$("#f_username").css("border-color","#F00");
						error+="- Обязательное поле \"Имя пользователя\" не заполнено! <br/>";
					}
					else
						$("#f_username").css("border-color","");
						
					if(!email_pattern.test($("#f_email").val()))
						{
							$("#f_email").css("border-color","#F00");
							error+="- Поле \"Email\" содержит недопустимые символы! <br/>";
						}
					else
						$("#f_email").css("border-color","");
					
					if(!site_pattern.test($("#f_site").val()))	
						{
							$("#f_site").css("border-color","#F00");
							error+="- Поле \"Сайт\" содержит недопустимые символы! <br/>";
						}
					else
						$("#f_site").css("border-color","");
						
					if(!phone_pattern.test($("#f_phone").val()))
						{
							$("#f_phone").css("border-color","#F00");
							error+="- Поле \"Телефон\" содержит недопустимые символы! <br/>";
						}
					else
						$("#f_phone").css("border-color","");
					
					if(age_pattern.test($("#f_age").val()) && parseInt($("#f_age").val()) >= 18 && parseInt($("#f_age").val())<=150)					
						$("#f_age").css("border-color","");					
					else
						{
							$("#f_age").css("border-color","#F00");
							error+="- Поле \"Возраст\" должно быть от 18 до 150! <br/>";
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
			<b>Имя пользователя:</b><br/>
			<input id="f_username" name="f_username" type="text" size="50" value="<?=$_POST["f_username"]?>"/><br/>
			<b>Email:</b><br/>
			<input id="f_email" name="f_email" type="text" size="15" value="<?=$_POST["f_email"]?>"/><br/>
			<b>Сайт:</b><br/>
			<input id="f_site" name="f_site" type="text" size="57" value="<?=$_POST["f_site"]?>"/><br/>
			<b>Телефон:</b><br/>
			<input id="f_phone" name="f_phone" type="text" size="25" value="<?=$_POST["f_phone"]?>"/><br/>
			<b>Возраст:</b><br/>
			<input id="f_age" name="f_age" type="text" size="3" value="<?=$_POST["f_age"]?>"/><br/>
			<b>Дополнительно:</b><br/>
			<textarea id="f_about" name="f_about" rows="5" cols="50"><?=$_POST["f_about"]?></textarea><br/>
			<div id="error" style="color: #F00"><?if(trim($error)!="") echo $error;?></div>
			<input id="js_supported" name="js_supported" type="hidden" value="no" />
			<input id="Send" name="Send" type="Submit" value="Сохранить"/>
		</form>
		<?=$msg?>
	</body>
</html>