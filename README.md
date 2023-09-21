# **Beetle Driver**
## Iago Carvalho e Leo Kenzo 📖
<p align="justify">

Vídeo mostrando o jogo: https://www.youtube.com/watch?v=BEa3T2DF4N8
 
 O nosso projeto criado em C# no Unity tem como objetivo um jogo 3D de corrida interminável que  é organizado em scripts diferentes, dividos cada um por uma função:

  
🔹 [Gameplay](#gameplay)<br><br>
🔹 [Design](#design) 


 </p>

 ## Gameplay
<p align="justify">

Prepare-se para a corrida infinita mais emocionante em Beetle Driver, um jogo desenvolvido no Unity que coloca você no papel de um habilidoso motorista em fuga! Assuma o controle de um fusca em alta velocidade. Sua única saída é acelerar e desviar dos carros que se movem rapidamente pela movimentada avenida.

O objetivo é percorrer a distância o mais longe possível, coletando uma quantidade específica de moedas valiosas ao longo do caminho. Mas cuidado! A avenida está repleta de veículos que podem acabar com sua fuga se você colidir com eles. Portanto, mostre suas habilidades de direção e reflexos para evitar acidentes e permanecer ileso na perseguição eletrizante. Principais funções:

A geração da avenida é feita usando um prefabs, criando segmentos "infinitos" da estrada.

A geração de carros inimigos é controlada por um sistema randomizado para garantir o desempenho e evitar instanciar e destruir objetos repetidamente. Os carros inimigos serão controlados por um sistema para definir caminhos entre o X e Z e evitar colisões.

Moedas estão espalhadas ao longo da avenida, e o jogador deverá coletá-las para aumentar sua pontuação. A detecção de coleta de moedas é feita através de colisores e tags especificas no script do jogador. Cada moeda coletada acrescentará um valor específico à pontuação total.
 </p>


 ## Design
<p align="justify">

Cena 1:
Nesta cena, o jogo apresentará um menu simples com duas opções de botões visíveis: "Iniciar" e "Sair". O jogador terá a escolha de iniciar o jogo ou sair dele.

Cena 2:
Ao selecionar "Iniciar" na cena anterior, o jogador será levado para uma paisagem urbana vibrante e neon, representando um cenário brasileiro. O jogo incluirá modelos de carros brasileiros como parte da jogabilidade. O objetivo do jogador será coletar uma quantidade específica de moedas para avançar para a próxima fase. 

Na última cena, o jogador será transportado para uma praia brasileira pitoresca, com paisagens alegres e, novamente, modelos de carros brasileiros fazendo parte do ambiente. O objetivo aqui também será coletar uma quantidade específica de moedas para concluir o jogo. A atmosfera da praia será complementada pela música de fundo "Saideira", criando uma experiência única para o jogador.

No geral, o jogo proporcionará uma experiência envolvente com uma trilha sonora de synthwave e brasileira que se adapta às diferentes cenas.

