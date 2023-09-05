//$(document).ready(function () {
//    // Sayfa yüklendiğinde popup otomatik olarak açılır
//    $("#popup").dialog({
//        autoOpen: true,
//        modal: true,
//        buttons: {
//            Kapat: function () {
//                $(this).dialog("close");
//            }
//        }
//    });

//});


<script>
    document.getElementById("submitButton").addEventListener("click", function () {
            var username = document.getElementById("username").value;
    var password = document.getElementById("password").value;
    var name = document.getElementById("name").value;
    var surname = document.getElementById("surname").value;
    var mail = document.getElementById("mail").value;


    if (username === "" || password === "" || name === "" || surname === "" || mail === "") {
        alert("Alanlar bos bırakılamaz.");
            }
      }
</script>
