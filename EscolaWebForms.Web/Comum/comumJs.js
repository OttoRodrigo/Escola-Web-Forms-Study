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

let nota = document.querySelector(".valid-js-nota");
if (nota != null) {
    nota.addEventListener("keyup", function (e) {
        if (isNaN(this.value) || this.value > 10 || this.value < 0) {
            nota.value = this.value.substring(0, this.value.length-1);
            e.preventDefault();
        }
    });
}