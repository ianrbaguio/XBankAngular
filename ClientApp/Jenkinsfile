pipeline{
    agent any

    stages{
        stage('Build'){
            steps{
                sh """npm install
                      npm run build-prod"""

            }
        }
        stage('Test'){
            steps{
                sh "echo 'Testing...'"
            }
        }
        stage('Deploy'){
            steps{
                sh """
                rm -rf /var/www/xbank-angular/dist
                cp -a ./dist/ /var/www/xbank-angular/dist"""
            }
        }
    }
}
