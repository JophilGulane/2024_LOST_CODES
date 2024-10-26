#include <iostream>

using namespace std;

void swap(int arr[], int pos1, int pos2) {
    int temp = arr[pos1];
    arr[pos1] = arr[pos2];
    arr[pos2] = temp;
}

int partition(int arr[], int start, int end) {
    int pivot = arr[end];
    int i = start - 1;

    for (int j = start; j < end; j++) {
        if (arr[j] < pivot) {
            i++;
            swap(arr, i, j);
        }
    }
    i++;
    swap(arr, i, end);
    return i;
}

void quicksort(int arr[], int start, int end) {
    if (end <= start) return;

    int pivot = partition(arr, start, end);
    quicksort(arr, start, pivot - 1);
    quicksort(arr, pivot + 1, end);


}

void colorsort(int arr[], int size) {
    int start = 0;
    int middle = 0;
    int end = size - 1;

    while (middle <= end) {
        if (arr[middle] == 0) {
            swap(arr, middle, start);
            start++;
            middle++;
        }
        else if (arr[middle] == 1) {
            middle++;
        }
        else if (arr[middle] == 2) {
            swap(arr, middle, end);
            end--;
        }
    }
}

int main() {
    int arr[] = {0 ,1,0,0,1,1,2,1,2,1,0,1,0 };
    int start = 0;
    int end = sizeof(arr) / sizeof(int) - 1;
    int size = sizeof(arr) / sizeof(int);

    //quicksort(arr, start, end);

    colorsort(arr,size);

    for (int i = 0; i <= end; i++) {
        cout << arr[i] << " ";
    }
}