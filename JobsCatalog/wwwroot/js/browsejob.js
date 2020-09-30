//Search job from Browse View
function resetInput()
		{
             $('input[name="category"]').prop('checked',false);
			  $('input[name="salary"]').prop('checked',false);
			   $('input[name="experience"]').prop('checked',false);
			   $('#keyword').val('');
			   $('#searchBtn').click()
		}
		jQuery(document).ready(function () {


			$('#searchBtn').on('click', function (e) {
				var keyword = $('#keyword').val();
				var category = $('input[name="category"]:checked').val();
				var salary = $('input[name="salary"]:checked').val();
				var exp = $('input[name="experience"]:checked').val();
				e.preventDefault();
				$.ajax({
					url: '/Job/JobFilter',
					type: "GET",
					data: {
						keyword: keyword,
						category: category,
						salary : salary,
						experience : exp
					},


					success: function (html) {

						$("#job-searchitems").replaceWith(html);




						return false;

					}
				});



			});
		});
	    //Save Job from JObDetails View
		$(function () {
		$('#isSaved').change(function () {
			var jobId = $('#jobId').val();
			$.ajax({
				url: '/Job/Save?jobId=' + jobId,
				cache: false,
				method: 'GET',
				success: function (response) {
					Snackbar.show({
							text: response.responseText,
							backgroundColor: "black",
							textColor: "white",
							actionText: "Dismiss"
						}

					);
				},
				error: function () {
					Snackbar.show({
							text: "Please login to save job 😠",
							backgroundColor: "black",
							textColor: "white",
							actionText: "Dismiss"
						}

					);
				}
			});
		});
	});

	

		//Click no on login request from jobdetails
	
      $('#noBtn').click(function() {
   Snackbar.show(
  {text: 'Die asshole 😡',
  backgroundColor: "black",
  duration : 10000,
textColor: "white",
  actionText: "Fuck you get lost"
  }
  
  );
});
     
