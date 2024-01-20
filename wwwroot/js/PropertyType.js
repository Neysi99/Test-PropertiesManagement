function validatePropertyTypeForm() {
    var description= document.getElementById("Description").value;


    if (if (description.trim() = "" ) {
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
