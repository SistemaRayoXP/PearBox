<?php
	$prefijo="";
	
	if($_SERVER['HTTPS'] == "on"){
		$prefijo="https://".$_SERVER['SERVER_NAME'];
	}else{
		$prefijo="http://".$_SERVER['SERVER_NAME'];
	}
	
	$inicio=' id="current"><a href="'.$prefijo.'"';
	$biblioteca='><a href="'.$prefijo.'/biblioteca/"';
	$articulos='><a href="'.$prefijo.'/articulos/"';
	$personal='><a href="'.$prefijo.'/personal/"';
	$nosotros='><a href="'.$prefijo.'/contacto/"';
	
	$dirlevel=explode('/', ltrim(str_replace('/index.php', '', $_SERVER['PHP_SELF']), '/'));
	#if(count($dirlevel) < 1){}
	
	$navrel='<ol class="navbar" id="rel">
			<li id="logo"><img alt="Tecnologias Armando" id="logo" src="'.$prefijo.'/logo.png"/></li>
			<li'.$inicio.'>Inicio</a></li>
			<li'.$biblioteca.'>Biblioteca</a></li>
			<li'.$articulos.'>Artículos</a></li>
			<li'.$personal.'>Personal</a></li>
			<li'.$nosotros.'>Acerca de nosotros</a></li>
		</ol>';
	$navfix='<ol class="navbar">
			<li id="logo"><img alt="Tecnologias Armando" id="logo" src="'.$prefijo.'/logo.png"/></li>
			<li'.$inicio.'>Inicio</a></li>
			<li'.$biblioteca.'>Biblioteca</a></li>
			<li'.$articulos.'>Artículos</a></li>
			<li'.$personal.'>Personal</a></li>
			<li'.$nosotros.'>Acerca de nosotros</a></li>
		</ol>';
		echo($navrel."\n".$navfix."\n");
?>