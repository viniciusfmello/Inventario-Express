function removerTudo() {
    // Adicione aqui o c�digo para remover todos os produtos
}

// Fun��o para atualizar o total do produto a ser removido
function atualizarTotal() {
    var quantidade = document.getElementById('quantidade').value;
    document.getElementById('total-remover').textContent = quantidade + '/50';
}

// Adiciona um ouvinte de evento para o evento 'input' no campo de entrada
document.getElementById('quantidade').addEventListener('input', atualizarTotal);