public class Ontario {

    public void Calculate(Client client) {
        Group ontario = client.ontario;
        ontario.R[10] = ontario.R[0] + ontario.R[1];

        if (ontario.R[10] > 50) {
            ontario.R[11] = ontario.R[10] * 10;
        }
    }
}