#include <stdio.h>

const int semester = 10;
const int subject = 6;
const int credit = 3;

void readScore (int score[semester][subject]) {
    for (int i = 0; i < semester; i++) {
        printf("Semester %d\n", i + 1);
        for (int j = 0; j < subject; j++) {
            printf("Subject %d : ", j + 1);
            scanf("%d", &score[i][j]);
        }
    }
}

char checkGrade(int score) {
    char grade;
    if (score >= 85 && score <= 100) {
        grade = 'A';
    	} else if(score >= 70) {
        grade = 'B';
    		} else if(score >= 60) {
        	grade = 'C';
    			} else if(score >= 55) {
        		grade = 'D';
    				} else if(score >= 0) {
        			grade = 'E';
    }
    return grade;
}

int convertGrade (char grade) {
    switch (grade) {
        case 'A':
           return 4;
        	case 'B':
            	   return 3;
        		case 'C':
            		   return 2;
        			case 'D':
            			   return 1;
        				default:
            				   return 0;
    }
}

float calculateSemesterGPA (int score [semester][subject], int curSemester) {
    float total = 0;
    for (int i = 0; i < subject; i++) {
        total += convertGrade(checkGrade(score[curSemester][i])) * credit;
    }
    return total / (subject * credit);
}

float calculateOverallGPA (int score[semester][subject]) {
    float total = 0;
    for (int i = 0; i < semester; i++) {
        total += calculateSemesterGPA(score, i);
    }
    return total / semester;
}

void printMinMax(int score[semester][subject]) {
    int min = 100, max = 0;
    for (int i = 0; i < semester; i++) {
        for (int j = 0; j < subject; j++) {
            if (score[i][j] > max) {
                max = score [i][j];
            } else if(score [i][j] < min) {
                min = score [i][j];
            }
        }
    }
    printf("Min score = %d\n", min);
    printf("Max score = %d\n", max);
}

void printTotalGrade(int score[semester][subject]) {
    int A = 0, B = 0, C = 0, D = 0, E = 0;
    for(int i = 0; i < semester; i++) {
        for(int j = 0; j < subject; j++) {
            switch (checkGrade(score[i][j])) {
                case 'A':
                    A++;
                    break;
                	case 'B':
                    	B++;
                    	break;
                		case 'C':
                    		C++;
                    		break;
                			case 'D':
                    			D++;
                    			break;
                				default:
                    				E++;
            }
        }
    }
    printf ("Total of A : %d\n", A);
    printf ("Total of B : %d\n", B);
    printf ("Total of C : %d\n", C);
    printf ("Total of D : %d\n", D);
    printf ("Total of E : %d\n", E);
}

int main() {
    int score[semester][subject], gpa[semester];
    readScore(score);

    printf("Print Grade Every Subject\n");
    for(int i = 0; i < semester; i++) {
        printf("Semester %d\n", i + 1);
        for(int j = 0; j < subject; j++) {
            printf("Subject %d = %c\n", j + 1, checkGrade(score[i][j]));
        }
    }

    printf("Grade Every Semester\n");
    for(int i = 0; i < semester; i++) {
        printf("Semester %d = %0.2f\n", i + 1, calculateSemesterGPA(score, i));
    }

    printf("Overall GPA = %0.2f\n", calculateOverallGPA(score));

    printMinMax(score);

    printTotalGrade(score);

    return 0;
}
