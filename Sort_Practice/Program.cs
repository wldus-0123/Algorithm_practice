namespace Sort_Practice
{
    internal class Program
    {
        // 1. 선택 정렬 : 데이터 중 가장 작은 값부터 하나씩 선택하여 정렬
        public static void SelectionSort(IList<int> list, int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j <= end; j++)
                {
                    if (list[j] < list[minIndex])
                        minIndex = j;
                }
                Swap(list, i, minIndex);
            }
        }


        // 2. 삽입 정렬 : 데이터를 하나씩 꺼내서 정렬된 자료 중 적합한 위치에 삽입하여 정렬

        public static void InsertionSort(IList<int>list, int start, int end)
        {
            for(int i = start; i <= end; i++)  // 처음 ~ 끝까지 반복
            {
                for(int j = i; j>=1; j--)
                {
                    if (list[j-1] < list[j]) // 앞자리랑 비교했을 때, 
                    {
                        break;
                    }
                    Swap(list, j-1, j); // 인덱스 바꾸기
                }
            }
        }


        // 3. 병합 정렬 : 데이터를 2분할하여 정렬 후 합병하는 방식 + 추가저장소가 필요함
        // 1단계 - 쪼개기
        // 2단계 - 부분배열 정렬하기 (쪼갠 배열들을 합치는 단계에서 이루어짐)
        // 3단계 - 하나의 배열에 합병하기
        public static void MergeSort(IList<int> list, int start, int end)
        {
            if(start == end) return;

            int mid = (start + end) / 2; // 중간 인덱스 값 구하기
            MergeSort(list, start, mid);// 중간 기준 왼쪽 정렬
            MergeSort(list, mid + 1, end);// 중간 기준 오른쪽 정렬
            Merge(list, start, mid, end); // 합치기
        }

        public static void Merge(IList<int> list, int start, int mid, int end)
        {
            // 임시 저장소 생성
            List<int> temp = new List<int> ();

            int leftIndex = start;// 왼쪽 시작 인덱스
            int rightIndex = mid + 1;// 오른쪽 시작 인덱스

            while (leftIndex<=mid && rightIndex <= end) // (왼쪽 시작 ~ 끝)(오른쪽 시작 ~ 끝)
            {
                if (list[leftIndex] < list[rightIndex])
                {
                    temp.Add(list[leftIndex]);  // 왼쪽이랑 오른쪽 비교해서 왼쪽이 작으면 임시저장소에 저장
                    leftIndex++; // 왼쪽 인덱스 한 칸 이동
                }
                else
                {
                    temp.Add(list[rightIndex]); // 오른쪽이 더 작으면 임시저장소에 오른쪽 값 저장
                    rightIndex++; // 오른쪽 인덱스 한 칸 이동
                }
            }

            // 왼쪽, 오른쪽 중 어느 한 칸이 먼저 빈 경우
            if(leftIndex>mid)  // 왼쪽이 먼저 빈 경우
            {
                // 오른쪽에 남은 값들 임시저장소에 추가
                for(int i = rightIndex; i<=end; i++)
                {
                    temp.Add(list[i]);
                }
            }
            else  // 오른쪽이 먼저 빈 경우
            {
                // 왼쪽에 남은 값들 임시저장소에 추가
                for(int i = leftIndex; i<=mid; i++)
                {
                    temp.Add(list[i]);
                }
            }

            // 현재 임시저장소 = 정렬되어있음 -> 임시저장소에 있는 값들 원본에 다시 저장
            for (int i = 0; i < temp.Count; i++) 
            {
                list[start+ i] = temp[i]; // 정렬시작지점 ~ 정렬
            }
        }

        // 4. 버블 정렬 : 서로 인접한 데이터를 비교하여 정렬함 (큰 데이터가 먼저 뒤에 쌓임)
        public static void BubbleSort(IList<int>list, int start, int end)
        {
            for(int i = start; i <= end-1; i++) // 처음 ~ 끝나기 직전까지 진행
            {
              for(int j = start; j < end - start; j++)
                {
                    if (list[j] > list[j + 1]) // 뒤에놈이랑 비교했을 때 내가 더 크면
                    {
                        Swap(list, j+1, j); // 나랑 뒤에놈 바꿈
                    }
                }
            }
        }

        public static void Swap(IList<int> list, int left, int right)
        {
            int temp = list[left];
            list[left] = list[right];
            list[right] = temp;
        }

               
        // 5. 퀵 정렬 : 피벗을 기준으로 작은값과 큰값을 2분할한 리스트를 생성
        public static void QuickSort(IList<int> list, int start, int end)
        {
            if (start >= end) return;

            // 피벗 선정하기
            int pivot = start;
            int left = pivot + 1; // 왼쪽에서 오른쪽으로 이동 : 피벗보다 큰 데이터를 찾으면 멈추기
            int right = end; // 오른쪽에서 왼쪽으로 이동 : 피벗보다 작은 데이터를 찾으면 멈추기

            while(left<= right) // 왼쪽과 오른쪽이 서로 엇갈릴 때까지 반복하기
            {
                while (list[left]<= list[pivot] && left<right) // 왼쪽 값이 피봇값보다 작고, 왼쪽 인덱스가 오른쪽 인덱스보다 작아야함
                {
                    left++;
                }
                while (list[right]>list[pivot] && left <= right) // 오른쪽 값이 피봇값보다 크고, 왼쪽 인덱스가 작거나 같아야함
                {
                    right--;
                }
                if(left < right)    // 엇갈리지 않았을 경우
                {
                    Swap(list, left, right);
                }
                else   // 엇갈렸을 경우
                {
                    Swap(list, pivot, right); // 피봇값을 가운데로 보내기
                    break;
                }
            }
            QuickSort(list, start, right - 1); // 중앙 기준 왼쪽 정렬 ( pivot 기준 작은 수) 
            QuickSort(list, right+1, end); // 중앙 기준 오른쪽 정렬 ( pivot 기준 큰 수)
        }

        static void Main(string[] args)
        {
            int[] test = { 3, 14, 2, 6, 1, 75, 24 };

            QuickSort(test,0,test.Length-1);

            foreach(int i in test)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
