# Exercise1-MVC

Tasks:

1. Add an attribute called "Director" to the movies and have them show up in the movie index table. (2 points)

2. Fix the broken link to the movie detail page (without changing its function in the controller). (3 points)

3. Add a button on the Movies page to show a random movie's details. (2 points)

4. Add a page to list 5 customers. Have it comply with the MVC framework. (4 points)

5. Add a link to the Customers page in the NavBar. (1 point)

# 2:

# Add pagination to the Movies page using Bootstrap

0. preparation step: add 13 movies to the movies list, bringing the total number of movies to 16.

1. Insert a pagination bar in your view.

2. Modify the controller so that it only gives a portion of the movies list to the view.

3. Pass a page number through the URL.

4. Tell your controller which movies to display based on the page number passed.

5. Add links to the pagination bar's buttons.

6. (Bonus) Prevent the user from using the previous/next page buttons when he is on the first/last page.

7. (Bonus) Prevent the user from throwing an exception when trying to reach page 0 or pages above the last page (error 404 is fine).

8. (Bonus) Do not have any hardcoded values (except for the movies list and the number of movies to show per page).
