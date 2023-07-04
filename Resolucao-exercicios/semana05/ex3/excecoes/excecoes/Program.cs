using excecoes;

Evento evento = new Evento();

evento.QtdIngressosVendidos = 15;
evento.QtdLugares = 12;

if (evento.QtdLugares - evento.QtdIngressosVendidos > 0)
{
    Console.WriteLine("Ingresso validado!");
    evento.ingressoVendido();
}
else
{
    throw new IngressoException("Não existem mais lugares" +
        " disponíveis para o evento");
}