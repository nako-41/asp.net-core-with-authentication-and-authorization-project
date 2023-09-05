const dogruCevaplar=["E","E","E","E"];
const form=document.querySelector('.soru-formu');
const result=document.querySelector('.result');

form.addEventListener('submit', e=> {
e.preventDefault();

 let score=0;
 const userAnsers=[form.q1.value,form.q2.value,form.q3.value,form.q4.value,form.q5.value];

 userAnsers.forEach((answer,index) =>{

     if(answer=== dogruCevaplar[index])
     {
         score += 20;
     }
 })

 result.classList.remove('d-none');
let puan =0;
const bastir = setInterval(() => {
    
    result.querySelector('span').textContent = `${puan}%`;
    if(puan==score)
    {
        clearInterval(bastir)
    }
    else{
        puan++;
    }
}, 20);



})



