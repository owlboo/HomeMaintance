
    function Delete(id) {
        debugger;
        $.ajax({
            url: "/Admin/Service/Delete",
            type: "POST",
            dataType: "json",
            data: { id: id },
        }).done(function (result) {
            window.location(-1);
        });


    }


