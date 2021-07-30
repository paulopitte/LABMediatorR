# LABMediatorR
Define um obj que encapsula a forma como um conjunto de objs interage.
o Mediator promove o acoplamento fraco ao evitar que os objetos se refiram uns aos outros de forma explícita e permite variar suas intereções independentemente.
<br>

<b>VANTAGENS</b>
<br><br>
1 - Desacoplamento entre objetos.
<br>
2 - Encapsulamento da comunicação entre Objetos.
<br>
3 - Os Objetos podem ser facilmente alterados pois são independentes.
<br><br>
<b>DESVANTAGENS</b>
<br><br>
1 - O mediador pode se tornar o gargalo da aplicação OBS: - (se tudo passar por ele).
<br>
2 - A complexidade do código aumenta. 
<br>
*************************************************************************
<br>
<b>Tipos de mensagens</b>
<br>
O mediatR despach dois tipos de mensagens
<br>
1- Mensagens de Request/Response => despachada para um único handler.
<br>
2- Mensagens de Notificação => despachada para múltiplos handlers.
<br><br>
<b>COMPONENTES PRINCIPAIS</b>

<BR><br>

1 - <strong>"REQUEST"</strong> -> Representa a mensagem a ser processada e possui propriedades para fazer o input dos dados para os handlers.<br>
2 - <strong>"HANDLER"</strong> -> Faz o processamento de determinada(s) mensagen(s).<br>
<br>
São implementados usando as interfaces IRequest e IRequestHandler
<br><br>

<strong>TIPOS DE REQUEST</strong>
<BR>
1 - IRequest => o request que não retorna um valor.<br>
2 - IRequest<T> => O request que retorna um valor.
<br><br>
Cada Request possiu o seu Handler
<br>
<br>
1 - IRequestHandler<T> => Para processamento que não retorna um valor.<br>
2 - IRequestHandler<T,U> => Para processamento que retorna um valor.<br>
<br>
<br>



