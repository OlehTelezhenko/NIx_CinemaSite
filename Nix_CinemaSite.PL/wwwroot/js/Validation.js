/*

titleFilm

filmDuration
descriptionFilm
statusFilm

day
month
year
*/

const Form = document.querySelector('form');
const testo = regExpTitle = /^[]{3,16}$/;

for(let elem of Form.elements)
    {
        if(!elem.classList.contains("form-check-input") && elem.tagName != 'BUTTON')
        {
            elem.addEventListener("blur", () => {validateElem(elem)});
        }
    }


Form.addEventListener('submit', (evem) =>
{
    evem.preventDefault();

    for(let elem of Form.elements)
    {
        if(!elem.classList.contains("form-check-input") && elem.tagName != 'BUTTON')
        {
            if(elem.value === "")
            {
                elem.classList.add('is-invalid');
            }else
            {
                elem.classList.add('is-valid');
            }
        }
    }
})

const validateElem = (elem) =>
{
    switch(elem.id)
    {
        case "titleFilm":
            let minLength = 1;
            let maxLength = 50;
            testLength(minLength, maxLength, elem);
        break;
        case "countryFilm":
            let minLength = 1;
            let maxLength = 50;
            testLength(minLength, maxLength, elem);
        break;
    }
}

void function testLength(minLength, maxLength, elem)
{
    let value = elem.value;
            if(value.length < minLength) 
            {
                elem.nextElementSibling.textContent = 'Введите название';
                elem.classList.add('is-invalid');
            }else
            if(value.length > maxLength) 
            {
                elem.nextElementSibling.textContent = 'Слишком длинное название';
                elem.classList.add('is-invalid');
            }else
            if(value.length >= minLength && value.length <= maxLength)
            {
                elem.nextElementSibling.textContent = '';
                elem.classList.replace('is-invalid', 'is-valid');
            }
}