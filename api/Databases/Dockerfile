# Use the latest MySQL image from Docker Hub
FROM mysql:latest

# Set environment variables
ENV MYSQL_ROOT_PASSWORD=root_password
ENV MYSQL_DATABASE=db
ENV MYSQL_USER=db_user
ENV MYSQL_PASSWORD=password

# Copy the SQL script into the container
COPY init.sql /docker-entrypoint-initdb.d/

# Expose port 3306 to allow external connections
EXPOSE 3306

# docker build -t mysql-custom .
# docker run -d -p 3306:3306 --name mysql-container mysql-custom