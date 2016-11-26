package cn.missbe;

/**
 * Created by Administrator on 2016/11/10 0010.
 */
public class algorithm {
    public static  Position BinarySearch0(int[] a,int x,int n){
        int left=0;
        int right=n-1;
       Position p=new Position();

        while(left <= right){
            p.setI(left);
            p.setJ(right);

            int middle=(left+right)/2;
            if(x==a[middle]){
                return new Position(middle,middle);
            }
            if(x>a[middle])
            {
//                p.setI(left);
                left=middle+1;
            }
            else{
//                p.setJ(right);
                right=middle-1;
            }

            System.out.println("left:"+left+" right:"+right);
        }
        return p;
    }
    public static  int BinarySearch1(int[] a,int x,int n){
        int left=0;
        int right=n-1;
        while(left <= right){
            int middle=(left+right)/2;
            if(x==a[middle])
                return middle;
            if(x>a[middle])
                left=middle+1;
            else
                right=middle-1;
            System.out.println("left:"+left+" right:"+right);
        }
        return -1;
    }
    public static  int BinarySearch2(int[] a,int x,int n){
        int left=0;
        int right=n-1;
        while(left <= right-1){
            int middle=(left+right)/2;
            if(x < a[middle])
                right=middle-1;
            else
                left=middle+1;
            System.out.println("left:"+left+" right:"+right);
        }
        if(x == a[left])
            return left;
        else
           return -1;
    }
    public static  int BinarySearch3(int[] a,int x,int n){
        int left=0;
        int right=n-1;
        while(left != right){
            int middle=(left+right)/2;
            if(x > a[middle])
                left=middle+1;
            else
                right=middle-1;
            System.out.println("left:"+left+" right:"+right);
        }
        if(x == a[left])
            return left;
        else
            return -1;
    }
    public static  int BinarySearch4(int[] a,int x,int n){
        if(n>0 && x>=a[0]){
            int left=0;
            int right=n-1;
            while(left < right){
                int middle=(left+right)/2;
                if(x < a[middle])
                    right=middle-1;
                else
                    left=middle+1;
                System.out.println("left:"+left+" right:"+right);
            }
            if(x == a[left])
                return left;
        }

        return -1;
    }
    public static  int BinarySearch5(int[] a,int x,int n){
        if(n>0 && x>=a[0]){
            int left=0;
            int right=n-1;
            while(left < right){
                int middle=(left+right+1)/2;
                if(x < a[middle])
                    right=middle-1;
                else
                    left=middle;
                System.out.println("left:"+left+" right:"+right+" a[middle]:"+a[middle]);
            }
            if(x == a[left])
                return left;
        }

        return -1;
    }
    public static  int BinarySearch6(int[] a,int x,int n){
        if(n>0 && x>=a[0]){
            int left=0;
            int right=n-1;
            while(left < right){
                int middle=(left+right)/2;
                if(x < a[middle])
                    right=middle-1;
                else
                    left=middle+1;
                System.out.printf("a[%d]=%d",middle,a[middle]);
                System.out.println("--left:"+left+" right:"+right);
            }
            if(x == a[left])
                return left;
        }

        return -1;
    }
    public static  int BinarySearch7(int[] a,int x,int n){
        if(n>0 && x>=a[0]){
            int left=0;
            int right=n-1;
            while(left < right){
                int middle=(left+right+1)/2;
                if(x < a[middle])
                    right=middle-1;
                else
                    left=middle;
                System.out.printf("a[%d]=%d",middle,a[middle]);
                System.out.println("--left:"+left+" right:"+right);
            }
            if(x == a[left])
                return left;
        }

        return -1;
    }
}
