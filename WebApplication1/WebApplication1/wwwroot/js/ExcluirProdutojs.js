function removerTudo() {
    // Adicione aqui o código para remover todos os produtos
}

// Função para atualizar o total do produto a ser removido
function atualizarTotal() {
    var quantidade = document.getElementById('quantidade').value;
    document.getElementById('total-remover').textContent = quantidade + '/50';
}

// Adiciona um ouvinte de evento para o evento 'input' no campo de entrada
document.getElementById('quantidade').addEventListener('input', atualizarTotal);