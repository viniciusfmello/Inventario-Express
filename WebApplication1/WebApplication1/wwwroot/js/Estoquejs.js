// Fun��o para abrir o modal de remo��o de estoque
function openRemoveStockModal(productName) {
    // Define o nome do produto no modal
    document.getElementById('removeStockModal').querySelector('.modal-title').innerText = 'Remover ' + productName + ' do Estoque';
    // Limpa o campo de quantidade
    document.getElementById('quantityToRemove').value = '';
    // Abre o modal
    $('#removeStockModal').modal('show');
}

// Fun��o para remover do estoque
function removeFromStock() {
    // Aqui voc� pode implementar a l�gica para remover a quantidade do estoque
    var quantityToRemove = document.getElementById('quantityToRemove').value;
    // Exemplo de l�gica: atualizar o banco de dados, API, etc.
    console.log('Remover ' + quantityToRemove + ' do estoque');
    // Fecha o modal
    $('#removeStockModal').modal('hide');
}