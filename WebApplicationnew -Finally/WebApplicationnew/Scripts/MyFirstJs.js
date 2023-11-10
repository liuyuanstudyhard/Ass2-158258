

    // Gets all the table rows
var rows = document.querySelectorAll(".table tbody tr");

// Creates a modal box element
var modal = document.createElement("div");
modal.classList.add("modal");
modal.innerHTML = `
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal">&times;</button>
                <h4 class="modal-title">Detailed Content of Works</h4>
            </div>
            <div class="modal-body">
                <div id="detailContent"></div>
                <div id="detailImage" style="height: 100px; width: 100px;"></div>
            </div>
        </div>
    </div>`;                          

// Adds a modal box element to the page
var container = document.querySelector(".table-container");
container.appendChild(modal);

// Gets the textarea element of the modal box
var detailTextarea = document.querySelector("#detailTextarea");

// Add a click event for each row of cells
for (var i = 0; i < rows.length; i++) {
    rows[i].addEventListener("click", function () {
        // Gets all the property contents of the current clicked row
        var attributes = this.getAttribute("data-attributes").split("|");
        var title = attributes[0];
        var author = attributes[1];
        var category = attributes[2];

        var Time = attributes[3];
        var Description = attributes[4];

        // Displays the details in the div of the modal box
        var detailContent = document.querySelector("#detailContent");
        detailContent.innerText = "Title: " + title + "\nAuthor: " + author + "\nTime: " + Time + "\nCategory: " + category + "\nDescription: " + Description;

        // Open the modal box
        modal.style.display = "block";
    });
}

// Close the mode box button click event
var closeButton = document.querySelector(".modal .close");
closeButton.addEventListener("click", function () {
    // Close the mode box
    modal.style.display = "none";
});




function showHistory(index) {
    var historyCards = document.querySelectorAll(".history-card");
    for (var i = 0; i < historyCards.length; i++) {
        historyCards[i].style.display = "none";
    }

    var selectedCard = document.querySelector(".history-card:nth-child(" + (index + 1) + ")");
    selectedCard.style.display = "block";

    var picture = selectedCard.querySelector(".history-picture");
    picture.style.display = "flex";
    picture.style.justifyContent = "center";
    picture.style.alignItems = "center";

}






function toggleDescription(image) {
    var description = image.parentElement.getElementsByClassName("description")[0];
    if (description.style.display === "none") {
        description.style.display = "block";
    } else {
        description.style.display = "none";
    }
}



function validateHTML() {
    var htmlContent = document.documentElement.outerHTML;

    var w3cValidatorUrl = "https://validator.w3.org/nu/";
  
    var w3cValidatorForm = document.createElement("form");
    w3cValidatorForm.method = "POST";
    w3cValidatorForm.enctype = "multipart/form-data";
    w3cValidatorForm.action = w3cValidatorUrl;
    w3cValidatorForm.target = "_blank";
    w3cValidatorForm.style.display = "none";

    var w3cValidatorInput = document.createElement("input");
    w3cValidatorInput.type = "hidden";
    w3cValidatorInput.name = "content";
    w3cValidatorInput.value = htmlContent;
    w3cValidatorForm.appendChild(w3cValidatorInput);

    document.body.appendChild(w3cValidatorForm);
    w3cValidatorForm.submit();
}

function validateCSS() {
    var cssContent = '';

    var styleSheets = document.styleSheets;
    for (var i = 0; i < styleSheets.length; i++) {
        var rules = styleSheets[i].cssRules;
        if (rules) {
            for (var j = 0; j < rules.length; j++) {
                cssContent += rules[j].cssText + '\n';
            }
        }
    }

    var cssValidatorUrl = "http://jigsaw.w3.org/css-validator/validator";

    var cssValidatorForm = document.createElement("form");
    cssValidatorForm.method = "POST";
    cssValidatorForm.enctype = "multipart/form-data";
    cssValidatorForm.action = cssValidatorUrl;
    cssValidatorForm.target = "_blank";
    cssValidatorForm.style.display = "none";

    var cssValidatorInput = document.createElement("input");
    cssValidatorInput.type = "hidden";
    cssValidatorInput.name = "text";
    cssValidatorInput.value = cssContent;
    cssValidatorForm.appendChild(cssValidatorInput);

    document.body.appendChild(cssValidatorForm);
    cssValidatorForm.submit();
}


