

var btn = document.getElementById('btn')


btn.onclick = function validate(idName, idAge){
    var idName = document.getElementById('name').value
    var idAge = document.getElementById('date').value
    if(typeof idName !=='string' && typeof date !== 'number' ){
        alert('Vui long nhập lại')
    }else{
        alert(`Bạn ${idName} được ${2021 - idAge} tuổi`)
    }
}