
const thisForm = document.getElementById('savePatient');
if (thisForm) {
   
    thisForm.addEventListener('submit', async function (e) {
        e.preventDefault();
    console.log("submit içi");
    const formData = new FormData(thisForm).entries();
    const response = await fetch('https://localhost:44334/api/AddPatient', {
        method: 'POST',
    headers: {
        'Content-Type': 'application/json',
    'Accept': 'application/json'
                },
    body: JSON.stringify(Object.fromEntries(formData))
            });
    console.log("fetch dışı");
    const result = await response.json();
    console.log(result)
        });
}