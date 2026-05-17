using ModelContextProtocol.Server;
using System.ComponentModel;

namespace McpProdutos.Tools;

[McpToolType]
public static class ProdutoTools
{
    [McpTool, Description("Lista todos os produtos")]
    public static string ListarProdutos()
    {
        return """
        [
            {
                "id": 1,
                "nome": "Notebook Gamer",
                "preco": 5500
            },
            {
                "id": 2,
                "nome": "Mouse RGB",
                "preco": 250
            },
            {
                "id": 3,
                "nome": "Teclado Mecânico",
                "preco": 450
            }
        ]
        """;
    }

    [McpTool, Description("Busca produto por ID")]
    public static string BuscarProduto(int id)
    {
        var produtos = new Dictionary<int, string>
        {
            {1, "Notebook Gamer"},
            {2, "Mouse RGB"},
            {3, "Teclado Mecânico"}
        };

        return produtos.TryGetValue(id, out var produto)
            ? produto
            : "Produto não encontrado";
    }
}