#include <stdio.h> // Aqui temos a biblioteca IO
#include <time.h>  // E aqui o tempo também, que vai rolar

int main() { // O nosso main, como sempre, é o dono da função
    time_t currentTime;  // Eis o tempo atual, em segundos, sem confusão
    struct tm *localTime;  // E agora o horário, formatado com perfeição

    time(&currentTime); // Peço para o tempo atual me dar a direção
    localTime = localtime(&currentTime); // Agora, é hora de formatar, sem hesitação

    printf("A hora atual é: %02d:%02d:%02d\n", // Com essa linha, imprimo no console
           localTime->tm_hour, localTime->tm_min, localTime->tm_sec); // A hora, os minutos e os segundos, com perfeita correção

    return 0;  // E é assim que o programa acaba, com sucesso e satisfação!
}
