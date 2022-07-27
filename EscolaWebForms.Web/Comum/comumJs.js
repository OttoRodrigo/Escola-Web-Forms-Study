let cpf = document.querySelector(".valid-js-cpf");
if (cpf != null) {
    cpf.addEventListener("keypress", function (e) {
        if (this.value.length > 11) {
            e.preventDefault();
        }
    });
}
//
let cep = document.querySelector(".valid-js-cep");
if (cep != null) {
    cep.addEventListener("keypress", function (e) {
        if (this.value.length > 7) {
            e.preventDefault();
        }
    });
}
//
function Mensagem(msg) {
    alert(msg);
}