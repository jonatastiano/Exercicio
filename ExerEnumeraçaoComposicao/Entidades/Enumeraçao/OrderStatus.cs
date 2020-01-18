using System;
using System.Collections.Generic;
using System.Text;

namespace ExerEnumeraçaoComposicao.Entidades.Enumeraçao {

    enum OrderStatus : int
    {
        Pagamento_Pendente = 0,
        Processando = 1,
        Enviando = 2,
        Entregue = 3
    }
}
