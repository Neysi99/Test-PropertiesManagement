
function validateOwnerForm() {
    var name = document.getElementById("Name").value;
    var telephone = document.getElementById("Telephone").value;
    var email = document.getElementById("Email").value;
    var identificationNumber = document.getElementById("IdentificationNumber").value;
    var address = document.getElementById("Address").value;
    
    if (if (name.trim() === "" || telephone.trim() === "" || email.trim() === "" || identificationNumber.trim() === "" || address.trim() === "") {
) {
      alert("All fields must be completed. Please complete.");
        return false;
    }

    return true;
}

document.addEventListener("DOMContentLoaded", function () {
    var ownerForm = document.getElementById("ownerForm");

    ownerForm.addEventListener("submit", function (event) {
        if (!validateOwnerForm()) {
            event.preventDefault();
        }
    });
});
