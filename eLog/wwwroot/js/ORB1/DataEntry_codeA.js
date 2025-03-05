$(document).ready(function () {
    // Handle form submission
    $('#CodeAForm').submit(function (event) {
        event.preventDefault(); // Prevent the form from submitting the traditional way

        // Collect form data
        var formData = {
            Date: $('#date').val(),
            BallastingOrCleaning: $('#ballastingOrCleaning').val(),
            DateLastCleaning: $('#dateLastCleaning').val(),
            OilCommercialName: $('#oilCommercialName').val(),
            DensityViscosity: $('#densityViscosity').val(),
            WasCleaned: $('#wasCleaned').val(),
            PreviousOilType: $('#PreviousOilType').val(),
            QuantityBallast: $('#QuantityBallast').val(),
            IdentityOfTanksBallasted: $('#IdentityOfTanksBallasted').val(),
            QuantityBallastTank: $('#quantityBallast').val()
        };

        // Make the AJAX request
        $.ajax({
            url: '@Url.Action("Submit", "ControllerName")', // Replace ControllerName with your actual controller name
            type: 'POST',
            data: formData,
            success: function (response) {
                $('#message').html('Data submitted successfully!');
            },
            error: function (xhr, status, error) {
                $('#message').html('Error occurred while submitting the data.');
            }
        });
    });
});
