window.renderOrderChart = (pending, completed, delivered) => {
    const ctx = document.getElementById('orderChart');

    if (!ctx) return;

    new Chart(ctx, {
        type: 'doughnut',
        data: {
            labels: ['Pending', 'Completed', 'Delivered'],
            datasets: [{
                data: [pending, completed, delivered],
                backgroundColor: ['#ffc107', '#198754', '#212529']
            }]
        },
        options: {
            responsive: true,
            plugins: {
                legend: {
                    position: 'bottom'
                }
            }
        }
    });
};