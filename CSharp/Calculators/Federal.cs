public class Alberta {

    public void Calculate(Client client) {
        Group federal = client.federal;
        Group ontario = client.ontario;
        Group alberta = client.alberta;

        federal.R[10] = ontario.R[10] + alberta.R[10];

        if (federal.R[10] > 50) {
            federal.R[11] = federal.R[10] * 10;
        }
    }
}