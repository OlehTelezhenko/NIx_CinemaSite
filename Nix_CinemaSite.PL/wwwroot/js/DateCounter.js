Counter("day", 1, 31);
Counter("month", 1, 12);
Counter('year', 1900, 2030)

function Counter (id ,fromNumber, toNumber)
{
  let _id = document.getElementById(id);
  for (let i = fromNumber; i <= toNumber; i++) {
    _id.innerHTML = _id.innerHTML + "<option>" + i + "</option>";
  }
}