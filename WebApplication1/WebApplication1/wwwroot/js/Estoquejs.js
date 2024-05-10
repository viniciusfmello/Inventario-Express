// Função para abrir o modal de remoção de estoque
function openRemoveStockModal(productName) {
    // Define o nome do produto no modal
    document.getElementById('removeStockModal').querySelector('.modal-title').innerText = 'Remover ' + productName + ' do Estoque';
    // Limpa o campo de quantidade
    document.getElementById('quantityToRemove').value = '';
    // Abre o modal
    $('#removeStockModal').modal('show');
}

// Função para remover do estoque
function removeFromStock() {
    // Aqui você pode implementar a lógica para remover a quantidade do estoque
    var quantityToRemove = document.getElementById('quantityToRemove').value;
    // Exemplo de lógica: atualizar o banco de dados, API, etc.
    console.log('Remover ' + quantityToRemove + ' do estoque');
    // Fecha o modal
    $('#removeStockModal').modal('hide');
}